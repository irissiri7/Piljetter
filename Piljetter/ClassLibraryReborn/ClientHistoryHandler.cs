using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ClassLibrary;


namespace ClassLibrary
{
    public static class ClientHistoryHandler
    {
        private static string ConnectionString { get; set; } = @"Data Source=MS713826\SQLEXPRESS;Initial Catalog=PiljettDb;Integrated Security=True";

        public static List<PurchaseHistory> GetCustomersPurchaseHistory(Customer customer)
        {
            
            var purchaseHistory = new List<PurchaseHistory>();

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();

                string sql = "SELECT o.Id as OrderID, o.Num_Tickets AS NumberOfTickets, a.Name AS Artist, " +
                    "s.Name AS Scene, s.City, s.Country, c.Time AS Date " +
                    "FROM Orders AS o " +
                    "INNER JOIN Concerts AS c ON o.Concert_Id = c.Id " +
                    "INNER JOIN Artists AS a ON c.Artist_Id = a.Id " +
                    "INNER JOIN Scenes AS s ON c.Scene_Id = s.Id " +
                    "WHERE o.Customer_Id = @id; ";

                purchaseHistory = c.Query<PurchaseHistory>(sql, new { @id = customer.Id}).ToList();
            };
            
            return purchaseHistory;
        }

        public static List<CouponInfoCustomer> GetCustomersCouponRecords(Customer customer)
        {

            var couponRecords = new List<CouponInfoCustomer>();

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();

                string sql = "SELECT Id as CouponId, Expiration_Date AS ExpirationDate " +
                    "FROM Coupons " +
                    "WHERE Customer_Id = @id " +
                    "ORDER BY ExpirationDate ";

                couponRecords = c.Query<CouponInfoCustomer>(sql, new { @id = customer.Id }).ToList();
            };

            return couponRecords;
        }
    }
}
