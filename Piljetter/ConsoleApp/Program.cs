using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        private static string ConnectionString { get; set; } = @"Data Source=MS713826\SQLEXPRESS;Initial Catalog=PiljettDb;Integrated Security=True";

        static void Main(string[] args)
        {

            MakeShitTonOfTicketPurchases();
        }

        public static void GenerateRandomCustomers()
        {
            Random rdn = new Random();
            var sqlInsertCustomers = "INSERT INTO Customers(Name, Pesetas, Password) " +
                "VALUES(@name, 100000, @password);";

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                for (int i = 0; i < 10000; i++)
                {
                    string name = GenerateRandomString();
                    string password = GenerateRandomString();

                    try
                    {
                        c.Execute(sqlInsertCustomers, new { @name = name, @password = password });
                    }
                    catch (SqlException)
                    {
                        continue;
                    }
                }
            }
                Console.WriteLine("All good and done!");
        }

        public static string GenerateRandomString(int len = 5)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }

        public static void GenerateSHitTonOfConcerts()
        {
            var sqlScenes = "SELECT Id FROM Scenes;";

            var sqlArtists = "SELECT Id FROM Artists;";

            var sqlInsertConcert = "INSERT INTO Concerts(Time, Scene_Id, Artist_Id, Ticket_Price, Available_Tickets, Total_Cost) " +
                "VALUES(@random, @randomScene, @randomArtist," +
                "(SELECT SUM(Popularity) * (100) FROM Artists as a WHERE a.Id = @randomArtist), " +
                "(SELECT Seats FROM Scenes WHERE Scenes.Id = @randomScene), " +
                "(SELECT(SELECT SUM(Renome) " +
                "FROM Scenes AS s WHERE s.Id = @randomScene) * " +
                "(SELECT SUM(Popularity) * (10000) " +
                "FROM Artists as a WHERE a.Id = @randomArtist))); ";

            Random rdn = new Random();

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                List<string> artists = c.Query<string>(sqlArtists).ToList();
                List<string> scenes = c.Query<string>(sqlScenes).ToList();

                for (int i = 0; i < 1000; i++)
                {
                    string year = rdn.Next(2020, 2025).ToString();
                    string month = rdn.Next(1, 31).ToString();
                    string day = rdn.Next(13, 29).ToString();
                    string randomDate = year + "-" + month + "-" + day;

                    try
                    {
                        c.Execute(sqlInsertConcert, new { @random = randomDate, @randomArtist = artists[rdn.Next(0, artists.Count())], @randomScene = scenes[rdn.Next(0, scenes.Count())] });
                    }
                    catch (SqlException)
                    {
                        continue;
                    }
                }

                Console.WriteLine("All good and done!");
            }
        }

        public static void MakeShitTonOfTicketPurchases()
        {
            var sqlCustomers = "SELECT Id FROM Customers;";

            var sqlConcerts = "SELECT Id FROM Concerts;";

            Random rdn = new Random();

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                List<Customer> customers = c.Query<Customer>(sqlCustomers).ToList();
                List<string> concerts = c.Query<string>(sqlConcerts).ToList();

                for (int i = 0; i < 1000; i++)
                {
                    VendingMachine.BuyTickets(customers[rdn.Next(0, customers.Count())], rdn.Next(1,5), int.Parse((concerts[rdn.Next(0, concerts.Count())])));                   }
                }

                Console.WriteLine("All good and done!");
            }

        }


    }



