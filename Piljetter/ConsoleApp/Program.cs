using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ClassLibrary;
using System.Configuration;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        private static string ConnectionString { get; set; } = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        static void Main(string[] args)
        {
            //GenerateRandomArtists();
            //GenerateRandomLocations();
            //GenerateRandomScenes();
            //GenerateRandomConcerts();
            //GenerateRandomCustomers();
            GenerateRandomTicketPurchases();
            //GenerateRandomCoupons();
        }

        public static void GenerateRandomArtists()
        {
            Random rdn = new Random();
            var sqlInsertArtist = "INSERT INTO Artists(Name, Popularity) " +
                "VALUES(@name, @popularity);";

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                for (int i = 0; i < 10000; i++)
                {
                    string name = GenerateRandomString();

                    try
                    {
                        c.Execute(sqlInsertArtist, new { @name = name, @popularity = rdn.Next(1,6) });
                    }
                    catch (SqlException)
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine("All good and done!");
        }
        
        public static void GenerateRandomLocations()
        {
            Random rdn = new Random();
            var sqlInsertArtist = "INSERT INTO Location(City, Country) " +
                "VALUES(@city, @country);";

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                for (int i = 0; i < 1000; i++)
                {
                    string city = GenerateRandomString();
                    string country = GenerateRandomString();

                    try
                    {
                        c.Execute(sqlInsertArtist, new { @city = city, @country = country});
                    }
                    catch (SqlException)
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine("All good and done!");
        }
        
        public static void GenerateRandomScenes()
        {
            string sqlAvailableLocations = @"SELECT Id FROM Location";
            
            string sqlInsertScenes = @"INSERT INTO Scenes(Name, Seats, Renome, Location_Id)
                                VALUES(@name, @seats, @renome, @location)";
            Random rdn = new Random();

            int[] seatVariations = { 1000, 2000, 3000, 4000, 5000, 6000, 7000 };

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                List<int> locationId = c.Query<int>(sqlAvailableLocations).ToList();
                for(int i = 0; i < 10000; i++)
                {
                    string name = GenerateRandomString();
                    int seats = seatVariations[rdn.Next(0, seatVariations.Count())];
                    int renome = rdn.Next(1, 6);
                    int location = sqlAvailableLocations[rdn.Next(0, sqlAvailableLocations.Count())];
                    try

                    {
                        c.Execute(sqlInsertScenes, new { @name = name, @seats = seats, @renome = renome, @location = location });

                    }
                    catch (SqlException e)
                    {
                        continue;
                    }

                }

            }
        }
       
        public static void GenerateRandomConcerts()
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
                List<int> artists = c.Query<int>(sqlArtists).ToList();
                List<int> scenes = c.Query<int>(sqlScenes).ToList();

                for (int i = 0; i < 10000; i++)
                {
                    string year = rdn.Next(2020, 2021).ToString();
                    string month = rdn.Next(1, 12).ToString();
                    string day = rdn.Next(13, 31).ToString();
                    string randomDate = year + "-" + month + "-" + day;

                    try
                    {
                        c.Execute(sqlInsertConcert, new { @random = randomDate, @randomArtist = artists[rdn.Next(0, artists.Count())], @randomScene = scenes[rdn.Next(0, scenes.Count())] });
                    }
                    catch (SqlException e)
                    {
                        continue;
                    }
                }

                Console.WriteLine("All good and done!");
                
            }
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

        public static void GenerateRandomTicketPurchases()
        {
            var sqlCustomers = "SELECT Id FROM Customers;";

            var sqlConcerts = "SELECT Id FROM Concerts;";

            Random rdn = new Random();

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                List<Customer> customers = c.Query<Customer>(sqlCustomers).ToList();
                List<string> concerts = c.Query<string>(sqlConcerts).ToList();

                for (int i = 0; i < 10000; i++)
                {
                    VendingMachine.BuyTickets(customers[rdn.Next(0, customers.Count())], rdn.Next(1, 5), int.Parse((concerts[rdn.Next(0, concerts.Count())])), false);
                }
            }

                Console.WriteLine("All good and done!");
            }

        public static void GenerateRandomCoupons()
        {
            var sqlCustomers = "SELECT Id FROM Customers;";
            var sqlInsertCoupons = "INSERT INTO Coupons(Customer_Id, Expiration_Date) " +
                "VALUES(@id, @date); ";
            
            Random rdn = new Random();

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                List<int> customers = c.Query<int>(sqlCustomers).ToList();
                
                for (int i = 0; i < 10000; i++)
                {
                    string year = rdn.Next(2020, 2025).ToString();
                    string month = rdn.Next(1, 13).ToString();
                    string day = rdn.Next(13, 29).ToString();
                    string randomDate = year + "-" + month + "-" + day;

                    try
                    {
                        c.Execute(sqlInsertCoupons, new { @date = randomDate, @id = customers[rdn.Next(0, customers.Count())] });
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Error?");
                        continue;
                    }
                }

                Console.WriteLine("All good and done!");
            }
        }

        public static string GenerateRandomString(int len = 5)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2;
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }


    }


}



