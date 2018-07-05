using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMinionNames
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Villain ID: ");
            int villainId = int.Parse(Console.ReadLine());
            bool villainExist = false;
            string connection = @"Server = .;
                               Database = Minions;
                               Integrated Security = true";
            SqlConnection con = new SqlConnection(connection);

            con.Open();

            string getVillainQry = File.ReadAllText(@"C:\Users\Dimitar Daskalov\Dropbox\SoftwareEngeneer\C#DBFundamentalsModule\AdvancedPlusEntityFrameworks\FetchingResultsetAdoDotNet\GetMinionNames\GetVillainName.sql");
            string getMinionsByVillain = File.ReadAllText(@"C:\Users\Dimitar Daskalov\Dropbox\SoftwareEngeneer\C#DBFundamentalsModule\AdvancedPlusEntityFrameworks\FetchingResultsetAdoDotNet\GetMinionNames\GetMinionsNames.sql");
            using (con)
            {
                SqlCommand getVillain = new SqlCommand(getVillainQry, con);
                getVillain.Parameters.AddWithValue("@Id", villainId);
                SqlDataReader reader = getVillain.ExecuteReader();

                using (reader)
                {
                    if (!reader.Read())
                    {
                        Console.WriteLine("No villain with ID 10 exists in the database.");
                    }
                    else
                    {
                        Console.WriteLine($"Villain: {reader[0]}");
                        villainExist = true;
                    }
                }
                if (villainExist)
                {
                    SqlCommand getMinions = new SqlCommand(getMinionsByVillain, con);
                    getMinions.Parameters.AddWithValue("@Id", villainId);
                    SqlDataReader minionsReader = getMinions.ExecuteReader();

                    using (minionsReader)
                    {
                        while (minionsReader.Read())
                        {
                            Console.WriteLine($"{minionsReader[0]} {minionsReader[1]}");
                        }
                    }
                }

            }
        }
    }
}
