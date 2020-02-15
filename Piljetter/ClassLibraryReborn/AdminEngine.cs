﻿using System;
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
            
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                string sql = "SELECT Name, Popularity, Id FROM Artists; ";
                List<AvailableArtistsView> result = c.Query<AvailableArtistsView>(sql).ToList();
                return result;
            }

        }

        public static List<AvailableScenesView> GetAvailableScenes()
        {

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                string sql = "SELECT Name, Renome, Id FROM Scenes; ";
                List<AvailableScenesView> result = c.Query<AvailableScenesView>(sql).ToList();
                return result;
            }

        }

        public static bool AddConcert(DateTime time, int sceneId, int artistId)
        {
            bool success = true;
            try
            {
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    using (var t = c.BeginTransaction())
                    {
                        string sql = "INSERT INTO Concerts(Time, Scene_Id, Artist_Id, Ticket_Price, Available_Tickets, Total_Cost) " +
                            "VALUES(@time, @sceneId, @artistId, " +
                            "(SELECT SUM(Popularity) * (100) FROM Artists as a WHERE a.Id = @artistId), " +
                            "(SELECT Seats FROM Scenes WHERE Scenes.Id = @sceneId), " +
                            "(SELECT(SELECT SUM(Renome) FROM Scenes AS s WHERE s.Id = @sceneId) * (SELECT SUM(Popularity) * (10000) FROM Artists as a WHERE a.Id = @artistId))); ";

                        c.Execute(sql, new { @time = time, @sceneId = sceneId, @artistId = artistId }, transaction: t);
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

        public static bool CancelConcert (string id, bool givecoupons)
        {
            bool success = true;
            if (givecoupons)
            {
                GiveCoupons(id);
            }
            try
            {
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    using (var t = c.BeginTransaction())
                    {
                        string sql = "WITH x AS " +
                            "(SELECT Customer_Id, SUM(Num_Tickets) as NumberOfTickets, AVG(Ticket_Price_At_Purchase) TicketPriceAtPurchase " +
                            "FROM Orders AS o " +
                            "WHERE o.Concert_Id = @id GROUP BY o.Customer_Id) " +
                            "UPDATE Customers " +
                            "SET Pesetas = Pesetas + (x.TicketPriceAtPurchase * x.NumberOfTickets) " +
                            "FROM Customers AS c " +
                            "INNER JOIN x AS x " +
                            "ON x.Customer_Id = c.Id; " +
                            "UPDATE Concerts " +
                            "SET Cancelled = 1 " +
                            "WHERE Id = @id";

                        c.Execute(sql, new { @id = id}, transaction: t);
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

        public static void GiveCoupons(string concertId)
        {
            var sql1 = "SELECT DISTINCT o.Customer_Id FROM Concerts AS c " +
                        "INNER JOIN Orders AS o ON c.Id = o.Concert_Id " +
                        "WHERE Concert_Id = @concertId;";  
            
            var sql2 = "INSERT INTO Coupons(Customer_Id, Expiration_Date) " +
                       "VALUES(@id, DATEADD(year, 1, GETDATE()));";
            
            using (var c = new SqlConnection(ConnectionString))
            {
                List<int> customerId= c.Query<int>(sql1, new { @concertId = concertId }).ToList();
                foreach (int id in customerId)
                {
                    c.Execute(sql2, new { @id = id });
                }
            }

        }

        public static List<TopArtistView> FindTopTenArtists(DateTime from, DateTime to)
        {
            using(var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var sql = "SELECT TOP 10 o.Concert_Id AS ConcertId, a.Name AS Artist, s.Name AS Scene, c.Time, CAST(ROUND(((SUM(Num_Tickets)*100.0) / s.Seats), 0) AS int) AS PercentageSoldOut " +
                    "FROM Orders AS o " +
                    "INNER JOIN Concerts AS c ON o.Concert_Id = c.Id " +
                    "INNER JOIN Artists AS a ON a.Id = c.Artist_Id " +
                    "INNER JOIN Scenes AS s ON c.Scene_Id = s.Id " +
                    "WHERE c.Cancelled = 0 AND c.Time BETWEEN @from AND @to " +
                    "GROUP BY a.Name, c.Time, Concert_Id, s.Seats, s.Name " +
                    "Order BY PercentageSoldOut DESC";

                List<TopArtistView> topArtistList = c.Query<TopArtistView>(sql, new { @from = from, @to = to }).ToList();

                return topArtistList;
            }
        }

        public static List<CouponInfoAdmin> CouponOverview()
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var sql = "SELECT DATEPART(YEAR FROM Expiration_Date) AS Year, ExpirationMonth, COUNT(*) NumberOfCoupons FROM ( " +
                    "SELECT *, " +
                    "CASE " +
                    "WHEN DATEPART(MONTH FROM Expiration_Date) = 1 THEN 'January' " +
                    "WHEN DATEPART(MONTH FROM Expiration_Date) = 2 THEN 'February' " +
                    "WHEN DATEPART(MONTH FROM Expiration_Date) = 3 THEN 'March' " +
                    "WHEN DATEPART(MONTH FROM Expiration_Date) = 4 THEN 'April' " +
                    "WHEN DATEPART(MONTH FROM Expiration_Date) = 5 THEN 'May' " +
                    "WHEN DATEPART(MONTH FROM Expiration_Date) = 6 THEN 'June' " +
                    "WHEN DATEPART(MONTH FROM Expiration_Date) = 7 THEN 'July' " +
                    "WHEN DATEPART(MONTH FROM Expiration_Date) = 8 THEN 'August' " +
                    "WHEN DATEPART(MONTH FROM Expiration_Date) = 9 THEN 'September' " +
                    "WHEN DATEPART(MONTH FROM Expiration_Date) = 10 THEN 'October' " +
                    "WHEN DATEPART(MONTH FROM Expiration_Date) = 11 THEN 'November' " +
                    "WHEN DATEPART(MONTH FROM Expiration_Date) = 12 THEN 'December' " +
                    "Else 'Unknown' " +
                   "END AS 'ExpirationMonth' " +
                   "FROM Coupons " +
                   "WHERE Expiration_Date >= GETDATE() " +
                   ") x " +
                   "GROUP BY DATEPART(YEAR FROM Expiration_Date), DATEPART(MONTH FROM Expiration_Date), ExpirationMonth " +
                   "ORDER BY DATEPART(YEAR FROM Expiration_Date), DATEPART(MONTH FROM Expiration_Date)";

                List<CouponInfoAdmin> couponSummery = c.Query<CouponInfoAdmin>(sql).ToList();

                return couponSummery;
            }
        }
    }
}
