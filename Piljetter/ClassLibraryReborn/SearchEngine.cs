using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Configuration;

namespace ClassLibrary
{
    public static class SearchEngine
    {
        private static string ConnectionString { get; set; } = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public static List<ConcertsView> SearchConcertsForCustomer(string artist, string scene, string country, string city, DateTime from, DateTime to)
        {
            string sql = @"Select c.Id, c.Time, a.Name Artist, s.Name Scene, l.Country, l.City, c.Available_Tickets AS AvailableTickets, c.Ticket_Price AS TicketPrice
                FROM Concerts as c 
                INNER JOIN Artists AS a ON a.Id = c.Artist_Id 
                INNER JOIN Scenes AS s ON s.Id = c.Scene_Id 
                INNER JOIN Location AS l ON s.Location_Id = l.Id 
                WHERE c.Cancelled = 0 AND a.Name LIKE @artist AND s.Name LIKE @scene AND l.Country LIKE @country AND l.City LIKE @city AND 
                c.Time BETWEEN @from AND @to 
                ORDER BY c.Time;";
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                List<ConcertsView> concerts = c.Query<ConcertsView>(sql, new {@artist = $"%{artist}%", @scene = $"%{scene}%", @country = $"{country}%", @city = $"{city}%", @from = from, @to = to } ).ToList();
                return concerts;
            };

        }

        public static List<ConcertsViewAdmin> SearchCommingConcertsForAdmin()
        {
            string sql = @"Select c.Id, c.Time, a.Name Artist, s.Name Scene, l.Country, l.City, s.Seats - c.Available_Tickets AS SoldTickets, c.Total_Cost AS Expense, (s.Seats - c.Available_Tickets) * c.Ticket_Price AS Earnings, (s.Seats - c.Available_Tickets) * c.Ticket_Price - c.Total_Cost AS TotalRevenue
                            FROM Concerts as c
                            INNER JOIN Artists as a ON a.Id = c.Artist_Id
                            INNER JOIN Scenes as s ON s.Id = c.Scene_Id
                            INNER JOIN Location AS l ON s.Location_Id = l.Id
                            WHERE c.Cancelled = 0 AND c.Time > GETDATE()
                            ORDER BY c.Time;";
            
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                List<ConcertsViewAdmin> commingConcerts = c.Query<ConcertsViewAdmin>(sql).ToList();
                return commingConcerts;
            };

        }

        public static List<ConcertsViewAdmin> SearchCancelledConcertsForAdmin()
        {
            string sql = @"Select c.Id, c.Time, a.Name Artist, s.Name Scene, l.Country, l.City, s.Seats - c.Available_Tickets AS SoldTickets, c.Total_Cost AS Expense, (s.Seats - c.Available_Tickets) * c.Ticket_Price AS Earnings, (s.Seats - c.Available_Tickets) * c.Ticket_Price - c.Total_Cost AS TotalRevenue
                FROM Concerts as c
                INNER JOIN Artists as a ON a.Id = c.Artist_Id 
                INNER JOIN Scenes as s ON s.Id = c.Scene_Id
                INNER JOIN Location AS l ON s.Location_Id = l.Id
                WHERE c.Cancelled = 1
                ORDER BY c.Time; ";
            
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                List<ConcertsViewAdmin> commingConcerts = c.Query<ConcertsViewAdmin>(sql).ToList();
                return commingConcerts;
            };

        }

        public static List<PurchaseHistory> GetCustomersPurchaseHistory(Customer customer)
        {

            var purchaseHistory = new List<PurchaseHistory>();
            string sql = @"SELECT o.Id as OrderID, o.Num_Tickets AS NumberOfTickets, a.Name AS Artist, 
                        s.Name AS Scene, l.City, l.Country, c.Time AS Date
                        FROM Orders AS o
                        INNER JOIN Concerts AS c ON o.Concert_Id = c.Id
                        INNER JOIN Artists AS a ON c.Artist_Id = a.Id
                        INNER JOIN Scenes AS s ON c.Scene_Id = s.Id
                        INNER JOIN Location AS l ON s.Location_Id = l.Id
                        WHERE o.Customer_Id = @id;";

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                purchaseHistory = c.Query<PurchaseHistory>(sql, new { @id = customer.Id }).ToList();
            };

            return purchaseHistory;
        }

        public static List<CouponInfoCustomer> GetCustomersCouponRecords(Customer customer)
        {

            var couponRecords = new List<CouponInfoCustomer>();
            string sql = "SELECT Id as CouponId, Expiration_Date AS ExpirationDate " +
                "FROM Coupons " +
                "WHERE Customer_Id = @id AND Used = 0 AND Expiration_Date > GETDATE()" +
                "ORDER BY ExpirationDate ";

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                couponRecords = c.Query<CouponInfoCustomer>(sql, new { @id = customer.Id }).ToList();
            };

            return couponRecords;
        }


    }
}
