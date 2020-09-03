using System.Data;
using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace testsql
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // String connString = @"Data Source=" + ds + ";Initial Catalog=" + db + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            String connString = @"server=localhost;userid=root;password=root;port=3306;database=sqlcore;SslMode=None";
            MySqlConnection conn = new MySqlConnection(connString);
            try {
                Console.WriteLine("opening connection...");
                
                String query1 = "SELECT * FROM contact";
                MySqlCommand command = new MySqlCommand(query1, conn);




                conn.Open();

                using(MySqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read()) {
                        Console.WriteLine(reader[0]);
                        Console.WriteLine(reader[1]);
                        Console.WriteLine(reader[2]);
                    }
                }


                Console.WriteLine("success!");
            }
            catch(Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();

        }
    }
}
