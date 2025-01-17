﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace ClassLibrary
{
    public static class VendingMachine
    {
        private static string ConnectionString { get; set; } = @"Data Source=MS713826\SQLEXPRESS;Initial Catalog=PiljettDb;Integrated Security=True";

        public static bool BuyTickets(Customer customer, int numOfTickets, int concertId)
        {
            bool success = true;
            try
            {
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    using (var t = c.BeginTransaction())
                    {
                        string sql = "UPDATE Concerts SET Available_Tickets = Available_Tickets - @numOfTickets " +
                            "WHERE Concerts.Id = @concertId; " +
                            "UPDATE Customers SET Pesetas = Pesetas - (@numOfTickets * ( SELECT Ticket_Price FROM Concerts WHERE Id = @concertId)) " +
                            "WHERE Id = @customerId; " +
                            "INSERT INTO Orders(Customer_Id, Concert_Id, Num_Tickets, Ticket_Price_At_Purchase) " +
                            "VALUES(@customerId, @concertId, @numOfTickets, (SELECT  Ticket_Price FROM Concerts WHERE Id = @concertId)); ";

                        c.Execute(sql, new { @numOfTickets  = numOfTickets, @concertId = concertId, @customerId = customer.Id }, transaction: t);
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

        public static bool BuyPesetas(Customer customer, int amountPesetas)
        {
            bool success = false;
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                string sql = "UPDATE Customers SET Pesetas = Pesetas + @amountPesetas WHERE Id = @Id; ";
                c.Execute(sql, new { @amountPesetas = amountPesetas, @Id = customer.Id});
                success = true;
            }

            return success;
        }
    }
}
