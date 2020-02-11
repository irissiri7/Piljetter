using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Linq;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public static class AdminEngine
    {
        private static string ConnectionString { get; set; } = @"Data Source=MS713826\SQLEXPRESS;Initial Catalog=PiljettDb;Integrated Security=True";

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

        public static bool CancelConcert (string id)
        {
            bool success = true;
            try
            {
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    using (var t = c.BeginTransaction())
                    {
                        string sql = "WITH x AS (SELECT Customer_Id, SUM(Num_Tickets) as NumberOfTickets, AVG(Ticket_Price_At_Purchase) TicketPriceAtPurchase " +
                            "FROM Orders AS o " +
                            "WHERE o.Concert_Id = @id GROUP BY o.Customer_Id) " +
                            "UPDATE Customers " +
                            "SET Pesetas = Pesetas + (x.TicketPriceAtPurchase * x.NumberOfTickets) " +
                            "FROM Customers AS c " +
                            "INNER JOIN x AS x " +
                            "ON x.Customer_Id = c.Id; " +
                            "DELETE FROM Orders WHERE Concert_Id = @id; " +
                            "DELETE FROM Concerts WHERE Id = @id; ";

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

    }
}
