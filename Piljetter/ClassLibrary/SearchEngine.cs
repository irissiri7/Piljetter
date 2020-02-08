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
        
        public static List<SearchResultConcerts> SearchConcerts(string artist, string scene, string country, string city)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                string sql = "Select c.Id, c.Time, a.Name Artist, s.Name Scene, s.Country, s.City FROM Concerts as c " +
                    "INNER JOIN Artists as a ON a.Id = c.Artist_Id " +
                    "INNER JOIN Scenes as s ON s.Id = c.Scene_Id " +
                    "WHERE a.Name LIKE @artist AND s.Name LIKE @scene AND s.Country LIKE @country AND s.City LIKE @city; ";

                List<SearchResultConcerts> concerts = c.Query<SearchResultConcerts>(sql, new {@artist = $"%{artist}%", @scene = $"%{scene}%", @country = $"%{country}%", @city = $"%{city}%" } ).ToList();
                return concerts;
            };

        }
    }
}
