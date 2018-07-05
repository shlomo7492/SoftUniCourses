using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreaseMinionAge
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Increasing Minion Age. Enter the sequence of Ids:");
            string[] ids = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string idString = string.Join(",", ids);
            string connection = @"Server = .;
                               Database = Minions;
                               Integrated Security = true";
            SqlConnection con = new SqlConnection(connection);
            List<string> names = new List<string>();
            con.Open();

            using (con)
            {
                SqlCommand cmd = new SqlCommand($@"UPDATE Minions
                                                SET Age+=1 
                                                WHERE Id IN ({ids})", con);
                cmd.ExecuteNonQuery();

                SqlCommand readCmd = new SqlCommand($@"Select m.Id,m.Name,m.Age
                                                FROM Minions AS m", con);
                //More to do... but got home complications... sorry
            }
        }
    }
}
