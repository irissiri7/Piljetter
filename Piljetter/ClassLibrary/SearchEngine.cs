using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace ClassLibrary
{
    public static class SearchEngine
    {
        private static string ConnectionString { get; set; } = @"Data Source=MS713826\SQLEXPRESS;Initial Catalog=PiljettDb;Integrated Security=True";
        
        public static void SearchAllConcerts()
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                string sql = "Select c.Time, a.Name Artist, s.Name Scene, s.Country, s.City FROM Concerts as c " +
                    "INNER JOIN Artists as a ON a.Id = c.Artist_Id " +
                    "INNER JOIN Scenes as s ON s.Id = c.Scene_Id " +
                    "WHERE a.Name LIKE '%%' AND s.Name LIKE '%%' AND s.Country LIKE '%%' AND s.City LIKE '%%'; ";
            };
        }
    }
}
