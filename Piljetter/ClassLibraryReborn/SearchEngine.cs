using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using System.Linq;


namespace ClassLibrary
{
    public static class SearchEngine
    {
        private static string ConnectionString { get; set; } = @"Data Source=MS713826\SQLEXPRESS;Initial Catalog=PiljettDb;Integrated Security=True";
        
        public static List<ConcertsView> SearchConcertsForCustomer(string artist, string scene, string country, string city, DateTime from, DateTime to)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                string sql = "Select c.Id, c.Time, a.Name Artist, s.Name Scene, s.Country, s.City, c.Available_Tickets AS AvailableTickets, c.Ticket_Price AS TicketPrice " +
                    "FROM Concerts as c " +
                    "INNER JOIN Artists as a ON a.Id = c.Artist_Id " +
                    "INNER JOIN Scenes as s ON s.Id = c.Scene_Id " +
                    "WHERE c.Cancelled = 0 AND a.Name LIKE @artist AND s.Name LIKE @scene AND s.Country LIKE @country AND s.City LIKE @city AND " +
                    "c.Time BETWEEN @from AND @to " +
                    "ORDER BY c.Time;";

                List<ConcertsView> concerts = c.Query<ConcertsView>(sql, new {@artist = $"%{artist}%", @scene = $"%{scene}%", @country = $"{country}%", @city = $"{city}%", @from = from, @to = to } ).ToList();
                return concerts;
            };

        }

        //PS, the 'time' variable is NOT a user input.
        public static List<ConcertsViewAdmin> SearchCommingConcertsForAdmin( string time)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                string sql = "Select c.Id, c.Time, a.Name Artist, s.Name Scene, s.Country, s.City, s.Seats - c.Available_Tickets AS SoldTickets, c.Total_Cost AS Expense, (s.Seats - c.Available_Tickets) * c.Ticket_Price AS Earnings, (s.Seats - c.Available_Tickets) * c.Ticket_Price - c.Total_Cost AS TotalRevenue " +
                    "FROM Concerts as c " +
                    "INNER JOIN Artists as a ON a.Id = c.Artist_Id " +
                    "INNER JOIN Scenes as s ON s.Id = c.Scene_Id " +
                    "WHERE c.Cancelled = 0 AND c.Time " + time + " GETDATE() " +
                    "ORDER BY c.Time; ";

                List<ConcertsViewAdmin> commingConcerts = c.Query<ConcertsViewAdmin>(sql).ToList();

                return commingConcerts;
            };

        }

        public static List<ConcertsViewAdmin> SearchCancelledConcertsForAdmin()
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                string sql = "Select c.Id, c.Time, a.Name Artist, s.Name Scene, s.Country, s.City, s.Seats - c.Available_Tickets AS SoldTickets, c.Total_Cost AS Expense, (s.Seats - c.Available_Tickets) * c.Ticket_Price AS Earnings, (s.Seats - c.Available_Tickets) * c.Ticket_Price - c.Total_Cost AS TotalRevenue " +
                    "FROM Concerts as c " +
                    "INNER JOIN Artists as a ON a.Id = c.Artist_Id " +
                    "INNER JOIN Scenes as s ON s.Id = c.Scene_Id " +
                    "WHERE c.Cancelled = 1 " +
                    "ORDER BY c.Time; ";

                List<ConcertsViewAdmin> commingConcerts = c.Query<ConcertsViewAdmin>(sql).ToList();

                return commingConcerts;
            };

        }


    }
}
