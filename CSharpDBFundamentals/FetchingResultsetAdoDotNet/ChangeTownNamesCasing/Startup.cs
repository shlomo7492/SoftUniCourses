using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTownNamesCasing
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.Write("Enter country name");
            string countryName = Console.ReadLine();
            string townName = "";
            Dictionary<int,string> towns = new Dictionary<int,string>();
            string connection = @"Server = .;
                               Database = Minions;
                               Integrated Security = true";
            SqlConnection con = new SqlConnection(connection);

            con.Open();

            using (con)
            {
                SqlCommand readCmd =new SqlCommand(@"SELECT t.Id
                                                    , t.Name 
                                                    FROM Towns AS t 
                                                    WHERE t.Country=@Country", con);
                readCmd.Parameters.AddWithValue("@Country", countryName);
                SqlDataReader reader = readCmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int idValue = (int)reader[0];
                        townName = reader[1].ToString().ToUpper();
                        //Console.WriteLine(reader[0]+" "+townName+" "+countryName);

                        //towns.Add(townName);
                        towns.Add(idValue,townName);
                    }
                }
                List<string> townOutput = new List<string>();
                foreach (KeyValuePair<int,string> element in towns)
                { 
                    SqlCommand cmd = new SqlCommand($@"UPDATE Towns
                                                        SET Name = '{element.Value}'
                                                        WHERE Id = {element.Key}", con);
                    cmd.ExecuteNonQuery();
                    townOutput.Add(element.Value);
                }
                 
                Console.WriteLine($"{townOutput.Count}town names were affected. ");
                Console.WriteLine("["+string.Join(", ", townOutput)+"]");
            }
        }
    }
}
