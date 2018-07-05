using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAllMinionNames
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordering minion names in order first,last,first+1,last-1... etc.");
            string connection = @"Server = .;
                               Database = Minions;
                               Integrated Security = true";
            SqlConnection con = new SqlConnection(connection);
            List<string> names = new List<string>();
            con.Open();

            using (con)
            {
                SqlCommand cmd = new SqlCommand(@"SELECT m.Name 
                                                    FROM Minions AS m", con);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    Console.WriteLine("::Original order::");
                    while (reader.Read())
                    {
                        names.Add((string)reader[0]);
                        Console.WriteLine(reader[0]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("::New Order::");
                int n = names.Count / 2;
                for (int i = 0; i < n; i++)
                {
                     Console.WriteLine(names[0+i]);
                     Console.WriteLine(names[(names.Count - 1) - i]);

                }
                if (names.Count % 2 != 0)
                {
                    Console.WriteLine(names[n]);
                }
            }
        }
    }
}
