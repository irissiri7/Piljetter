using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Linq;
using System.Data.SqlClient;
using ClassLibraryReborn.POCOS;
using System.Configuration;

namespace ClassLibrary
{
    public static class AdminEngine
    {
        private static string ConnectionString { get; set; } = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;


        public static List<AvailableArtistsView> GetAvailableArtists()
        {
            string sql = @"SELECT * FROM Artists";
            
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                List<AvailableArtistsView> result = c.Query<AvailableArtistsView>(sql).ToList();
                return result;
            }

        }

        public static List<AvailableScenesView> GetAvailableScenes()
        {
            string sql = @"SELECT s.Id, s.Name, l.City, s.Renome, s.Seats 
                            FROM Scenes AS s
                            INNER JOIN Location AS l ON s.Location_Id = l.Id;";

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                List<AvailableScenesView> result = c.Query<AvailableScenesView>(sql).ToList();
                return result;
            }

        }

        public static bool AddConcert(DateTime time, int sceneId, int artistId, out string message)
        {
            bool success = true;
            message = "Concert added!";
            
            string sqlAddConcert = @"INSERT INTO Concerts(Time, Scene_Id, Artist_Id, Ticket_Price, Available_Tickets, Total_Cost)
                VALUES(@time, @sceneId, @artistId,
                (SELECT SUM(Popularity) * (100) FROM Artists as a WHERE a.Id = @artistId),
                (SELECT Seats FROM Scenes WHERE Scenes.Id = @sceneId),
                (SELECT(SELECT SUM(Renome) FROM Scenes AS s WHERE s.Id = @sceneId) * (SELECT SUM(Popularity) * (10000) FROM Artists as a WHERE a.Id = @artistId))); ";
            
            try
            {
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    bool sceneAlreadyBooked = CheckIfSceneIsAlreadyBookedThatDate(time, sceneId);
                    bool artistAlreadyBooked = CheckIfArtistIsAlreadyBookedThatDate(time, artistId);
                    if (artistAlreadyBooked)
                    {
                        message = "Artist already booked on that date";
                        throw new InvalidOperationException();

                    }
                    else if (sceneAlreadyBooked)
                    {
                        message = "Scene already booked on that date";
                        throw new InvalidOperationException();

                    }
                    else
                    {
                        using (var t = c.BeginTransaction())
                        {

                            c.Execute(sqlAddConcert, new { @time = time, @sceneId = sceneId, @artistId = artistId }, transaction: t);
                            t.Commit();
                        }

                    }
                }
            }
            catch (Exception e)
            {
                success = false;
                if(e is SqlException || e is InvalidOperationException)
                {
                    return success;
                }
                else
                {
                    message = "Unknown error";
                    throw;
                }
            }

            return success;
        }

        public static bool CancelConcert (string concertId, bool givecoupons)
        {
            bool success = true;
            string sqlCustomersToRefund = @"SELECT Customer_Id AS CustomerId, SUM(Num_Tickets) AS NumberOfTickets, 
                                         Ticket_Price_At_Purchase AS TicketPriceAtPurchase 
                                         FROM Orders AS o WHERE o.Concert_Id = @concertId 
                                         GROUP BY o.Customer_Id, Ticket_Price_At_Purchase";

            string sqlRefundStatement = @"UPDATE Customers
                                         SET Pesetas = Pesetas + (@ticketPrice * @numberOfTickets)
                                          WHERE Id = @customerId";


           string sqlCancelConcert = @"UPDATE Concerts
                                        SET Cancelled = 1
                                        WHERE Id = @concertId";
                                       
            try
            {
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    List<CustomerToRefund> customersToRefund = c.Query<CustomerToRefund>(sqlCustomersToRefund, new { @concertId = concertId }).ToList();
                    using (var t = c.BeginTransaction())
                    {
                        c.Execute(sqlCancelConcert, new { @concertId = concertId }, transaction: t);
                        if (givecoupons)
                        {
                            GiveCoupons(concertId, c, t);
                        }
                        foreach(var customer in customersToRefund)
                        {
                            c.Execute(sqlRefundStatement, new {@ticketPrice = customer.TicketPriceAtPurchase, @numberOfTickets = customer.NumberOfTickets, @customerId = customer.CustomerId}, transaction: t);
                        }
                        
                        t.Commit();
                    }
                }
            }
            catch (SqlException e)
            {
                success = false;
            }


            return success;
        }

        public static void GiveCoupons(string concertId, SqlConnection con, SqlTransaction tran)
        {
            var sqlCustomers = @"SELECT DISTINCT Customer_Id 
                                FROM Orders
                                WHERE Concert_Id = @concertId;";  
            
            var sqlInsertCoupons = @"INSERT INTO Coupons(Customer_Id, Expiration_Date)
                                    VALUES(@id, DATEADD(year, 1, GETDATE()));";
            
                List<int> customerId= con.Query<int>(sqlCustomers, new { @concertId = concertId }, tran).ToList();
                foreach (int id in customerId)
                {
                    con.Execute(sqlInsertCoupons, new { @id = id }, tran);
                }
        }

        public static List<TopArtistView> FindTopTenArtists(DateTime from, DateTime to)
        {
            using(var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var sql = @"SELECT TOP 10 o.Concert_Id AS ConcertId, a.Name AS Artist, s.Name AS Scene, c.Time, CAST(ROUND(((SUM(Num_Tickets)*100.0) / s.Seats), 0) AS int) AS PercentageSoldOut
                    FROM Orders AS o
                    INNER JOIN Concerts AS c ON o.Concert_Id = c.Id
                    INNER JOIN Artists AS a ON a.Id = c.Artist_Id 
                    INNER JOIN Scenes AS s ON c.Scene_Id = s.Id 
                    WHERE c.Cancelled = 0 AND c.Time BETWEEN @from AND @to 
                    GROUP BY a.Name, c.Time, Concert_Id, s.Seats, s.Name 
                    Order BY PercentageSoldOut DESC";

                List<TopArtistView> topArtistList = c.Query<TopArtistView>(sql, new { @from = from, @to = to }).ToList();

                return topArtistList;
            }
        }

        public static List<CouponInfoAdmin> CouponOverview()
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var sql = @"SELECT DATEPART(YEAR FROM Expiration_Date) AS Year, ExpirationMonth, COUNT(*) NumberOfCoupons FROM (
                    SELECT *,
                    CASE
                    WHEN DATEPART(MONTH FROM Expiration_Date) = 1 THEN 'January'
                    WHEN DATEPART(MONTH FROM Expiration_Date) = 2 THEN 'February'
                    WHEN DATEPART(MONTH FROM Expiration_Date) = 3 THEN 'March'
                    WHEN DATEPART(MONTH FROM Expiration_Date) = 4 THEN 'April'
                    WHEN DATEPART(MONTH FROM Expiration_Date) = 5 THEN 'May'
                    WHEN DATEPART(MONTH FROM Expiration_Date) = 6 THEN 'June'
                    WHEN DATEPART(MONTH FROM Expiration_Date) = 7 THEN 'July'
                    WHEN DATEPART(MONTH FROM Expiration_Date) = 8 THEN 'August'
                    WHEN DATEPART(MONTH FROM Expiration_Date) = 9 THEN 'September'
                    WHEN DATEPART(MONTH FROM Expiration_Date) = 10 THEN 'October'
                    WHEN DATEPART(MONTH FROM Expiration_Date) = 11 THEN 'November'
                    WHEN DATEPART(MONTH FROM Expiration_Date) = 12 THEN 'December'
                    Else 'Unknown'
                   END AS 'ExpirationMonth'
                   FROM Coupons
                   WHERE Expiration_Date >= GETDATE() AND Used = 0
                   ) x 
                   GROUP BY DATEPART(YEAR FROM Expiration_Date), DATEPART(MONTH FROM Expiration_Date), ExpirationMonth
                   ORDER BY DATEPART(YEAR FROM Expiration_Date), DATEPART(MONTH FROM Expiration_Date)";

                List<CouponInfoAdmin> couponSummery = c.Query<CouponInfoAdmin>(sql).ToList();

                return couponSummery;
            }
        }

        public static bool CheckIfArtistIsAlreadyBookedThatDate(DateTime time, int artistId)
        {
            bool result = false;
            using(var cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                var sql = "SELECT Artist_Id FROM Concerts WHERE Time = @time AND Artist_Id = @artistId AND Cancelled = 0";
                
                List<int> artistAlreadyBooked = cn.Query<int>(sql, new { @time = time.ToString("yyyy/MM/dd"), @artistId = artistId }).ToList();
                if(artistAlreadyBooked.Count > 0)
                {
                    result = true;
                }
            }
            return result;
        }

        public static bool CheckIfSceneIsAlreadyBookedThatDate(DateTime time, int sceneId)
        {
            bool result = false;
            using (var cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                var sql = "SELECT Scene_Id FROM Concerts WHERE Time = @time AND scene_Id = @sceneId AND Cancelled = 0";

                List<int> artistAlreadyBooked = cn.Query<int>(sql, new { @time = time.ToString("yyyy/MM/dd"), @sceneId = sceneId }).ToList();
                if (artistAlreadyBooked.Count > 0)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
