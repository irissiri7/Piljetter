using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace ClassLibrary
{
    public class SignInHandler
    {
        public static List<Customer> SignIn(string name, string password)
        {
            var connectionString = @"Data Source=MS713826\SQLEXPRESS;Initial Catalog=PiljettDb;Integrated Security=True";
            var customer = new List<Customer>();
            
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                customer = c.Query<Customer>("SELECT * FROM [Customers] WHERE Name = @name AND Password = @password;", new { @name = name, @password = password }).ToList();
            };
                return customer;
        }
    }
}