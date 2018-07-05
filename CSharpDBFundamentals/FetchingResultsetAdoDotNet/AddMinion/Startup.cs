using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddMinion
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Minion data:");
            char[] spliters = new char[] { ' ' };
            string[] minion = Console.ReadLine().Split(spliters, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
            Console.Write("Enter Minions Villain:");
            string villainName = Console.ReadLine().Split(spliters, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToString();
           

            string connection = @"Server = .;
                               Database = Minions;
                               Integrated Security = true";
            SqlConnection con = new SqlConnection(connection);

            con.Open();

            using (con)
            {
                int newMinionId = GetLastMinionId(con);
                int newTownId = GetTownId(minion[2], con);
                AddMinion(newMinionId, minion[0], minion[1], newTownId, con);
                int villainId = GetVillainID(villainName,con);
                SetVillainToMinionRelations(villainId, newMinionId, con);
            }
            //con.Close();
        }
        static void AddMinion(int newId, string name, string age, int townId, SqlConnection con)
        {
            using (con)
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Minions
                                                VALUES (@NewId,@Name,@Age,@TownId)"
                                                , con);
                cmd.Parameters.AddWithValue("@NewId", newId);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@TownId", townId);

                Console.WriteLine(cmd.ExecuteNonQuery());
            }
        }
        static int GetTownId(string townName, SqlConnection con)
        {
            int newTownId=1;
            using (con)
            {
                SqlCommand cmd = new SqlCommand(@"SELECT t.Id
                                    FROM Towns AS t
                                    WHERE t.Name = @Name"
                                   , con);
                cmd.Parameters.AddWithValue("@Name", townName);
                SqlDataReader townReader = cmd.ExecuteReader();
                using (townReader)
                {
                    if (townReader.Read())
                    {
                        return newTownId = (int)townReader[0];
                    }
                    else
                    {
                        newTownId = GetLastTownId(con);
                        AddTown(newTownId, townName, con);
                        return newTownId;
                    }
                }
            }
        }
        static int GetLastTownId( SqlConnection con)
        {
            int newTownId = 0;
            using (con)
            {
                SqlCommand getLast = new SqlCommand(@"SELECT TOP (1) t.Id
                                                         FROM Towns AS t
                                                         ORDER BY t.Id DESC", con);
                SqlDataReader readLast = getLast.ExecuteReader();
                using (readLast)
                {
                    readLast.Read();
                    newTownId = (int)readLast[0] + 1;
                    return newTownId;
                }
            }
        }
        static int GetLastMinionId(SqlConnection con)
        {
            int newId = 0;
            using (con)
            {
                SqlCommand cmd = new SqlCommand( @"SELECT TOP (1) m.Id
                                         FROM Minions AS m
                                         ORDER BY m.Id DESC",con);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    reader.Read();
                    //Console.WriteLine((int)reader[0] + 1);
                    return newId = (int)reader[0] + 1;
                }
            }
        }
        static void AddTown(int newId,string TownName, SqlConnection con)
        {
            using (con)
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Towns VALUES(@NewID, @Name)", con);
                cmd.Parameters.AddWithValue("@NewId", newId);
                cmd.Parameters.AddWithValue("@Name", TownName);
                Console.WriteLine(cmd.ExecuteNonQuery());
            }
        }
        static int GetVillainID(string name, SqlConnection con)
        {
            int villainId = 0;
            using (con)
            {
                SqlCommand cmd = new SqlCommand(@"SELECT v.Id
                                    FROM Villains AS v
                                    WHERE v.Name = @Name"
                                   , con);
                cmd.Parameters.AddWithValue("@Name", name);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        return villainId = (int)reader[0];
                    }
                    else
                    {
                        villainId = GetLastVillainId(con);
                        AddVillain(villainId, name,con);
                        return villainId;
                    }
                }
            }
        }
        static int GetLastVillainId(SqlConnection con)
        {
            int villainId = 0;
            using (con)
            {
                SqlCommand cmd = new SqlCommand(@"SELECT TOP (1) v.Id
                                         FROM Villains AS v
                                         ORDER BY v.Id DESC", con);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    reader.Read();
                    return villainId = (int)reader[0] + 1; 
                }
                   
            }

        }
        static void AddVillain(int villainId, string name,SqlConnection con)
        {
            using (con)
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Villain
                                                VALUES (@NewId,@Name,'evil')"
                                                , con);
                cmd.Parameters.AddWithValue("@NewId", villainId);
                cmd.Parameters.AddWithValue("@Name", name);
                

                Console.WriteLine(cmd.ExecuteNonQuery());
            }
        }
        static void SetVillainToMinionRelations(int villain, int minion, SqlConnection con)
        {
            using (con)
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO VillainMinions
                                                VALUES (@vID,@minID,'evil')"
                                                , con);
                cmd.Parameters.AddWithValue("@vID", villain);
                cmd.Parameters.AddWithValue("@minID", minion);

                Console.WriteLine(cmd.ExecuteNonQuery());
            }
        }
    }
}
