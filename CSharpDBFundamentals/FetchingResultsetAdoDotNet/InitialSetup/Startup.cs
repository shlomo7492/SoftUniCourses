
namespace InitialSetup
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
            //string connection = @"Server=.;
            //                   Integrated Security = true";
            //SqlConnection con = new SqlConnection(connection);
            //con.Open();
            //CreateDB("Minions", con);
            //con.Close();

            string connection=@"Server = .;
                               Database = Minions;
                               Integrated Security = true";
            string createDBTables = File.ReadAllText(@"C:\Users\Dimitar Daskalov\Dropbox\SoftwareEngeneer\C#DBFundamentalsModule\AdvancedPlusEntityFrameworks\FetchingResultsetAdoDotNet\InitialSetup\CreateTables.sql");
            string insertQuery = File.ReadAllText(@"C:\Users\Dimitar Daskalov\Dropbox\SoftwareEngeneer\C#DBFundamentalsModule\AdvancedPlusEntityFrameworks\FetchingResultsetAdoDotNet\InitialSetup\InsertQuery.sql");
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            //CreateDBTables(createDBTables, con);
            InsertIntoDB(insertQuery, con);
            con.Close();
        }
        static void CreateDB(string dataBaseName, SqlConnection con)
        {
            using (con)
            {
                SqlCommand createDBcommand = new SqlCommand($"CREATE DATABASE {dataBaseName}",con);
                createDBcommand.ExecuteNonQuery();
            }
        }
        static void CreateDBTables(string createTableQuery, SqlConnection con)
        {
            using (con)
            {
                SqlCommand createTables = new SqlCommand(createTableQuery, con);
                createTables.ExecuteNonQuery();
            }
        }
        static void InsertIntoDB(string insertQuery, SqlConnection con)
        {
            using (con)
            {
                SqlCommand createTables = new SqlCommand(insertQuery, con);
                createTables.ExecuteNonQuery();
            }
        }
    }
}
