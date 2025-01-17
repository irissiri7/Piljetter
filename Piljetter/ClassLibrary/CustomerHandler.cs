﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace ClassLibrary
{
    public static class CustomerHandler
    {
        private static string ConnectionString { get; set; } = @"Data Source=MS713826\SQLEXPRESS;Initial Catalog=PiljettDb;Integrated Security=True";

        public static List<Customer> SignIn(string name, string password)
        {
            var customer = new List<Customer>();

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                string sql = "SELECT * FROM [Customers] WHERE Name = @name AND Password = @password;";
                customer = c.Query<Customer>(sql, new { @name = name, @password = password }).ToList();
            };
            return customer;
        }

        public static bool RegisterNewCustomer(string name, string password)
        {
            bool sucess = true;
            try
            {
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    string sql = "INSERT INTO Customers(Name, Password) VALUES(@name, @password); ";
                    c.Execute(sql, new { @name = name, @password = password });
                }

            }
            catch(SqlException e)
            {
                sucess = false;
            }

            return sucess;
        }

    }
}

