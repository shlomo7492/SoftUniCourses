

namespace GetVillainsNames
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Startup
    {
        static void Main(string[] args)
        {
            string query = File.ReadAllText(@"C:\Users\Dimitar Daskalov\Dropbox\SoftwareEngeneer\C#DBFundamentalsModule\AdvancedPlusEntityFrameworks\FetchingResultsetAdoDotNet\2. GetVillainsNames\GetVillainsNames.sql");

            string connection = @"Server = .;
                               Database = Minions;
                               Integrated Security = true";
            SqlConnection con = new SqlConnection(connection);

            con.Open();
            using (con)
            {
                SqlCommand getData = new SqlCommand(query, con);
                SqlDataReader queryReader = getData.ExecuteReader();

                while (queryReader.Read())
                {
                    Console.WriteLine($"{queryReader[0],-10} | {queryReader[1],-3}");
                }
            }
        
        }
    }
}
