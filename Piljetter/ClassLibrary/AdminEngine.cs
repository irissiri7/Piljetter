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

    }
}
