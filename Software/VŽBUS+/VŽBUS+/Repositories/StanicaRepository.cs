using System.Collections.Generic;
using System.Data.SqlClient;
using DBLayer;
using VŽBUS_.Models;

namespace VŽBUS_.Repositories
{
    public static class StanicaRepository
    {
        public static List<Stanica> GetStanice()
        {
            List<Stanica> stanice = new List<Stanica>();
            string sql = "SELECT * FROM Stanica";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Stanica stanica = CreateObject(reader);
                stanice.Add(stanica);
            }
            reader.Close();
            DB.CloseConnection();
            return stanice;
        }

        public static void InsertStanica(Stanica stanica)
        {
            string sql = $"INSERT INTO Stanica (Naziv, Lokacija) VALUES ('{stanica.Naziv}', '{stanica.Lokacija}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateStanica(Stanica stanica)
        {
            string sql = $"UPDATE Stanica SET Naziv = '{stanica.Naziv}', Lokacija = '{stanica.Lokacija}' WHERE ID_stanice = {stanica.ID_stanice}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteStanica(int id)
        {
            string sql = $"DELETE FROM Stanica WHERE ID_stanice = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        private static Stanica CreateObject(SqlDataReader reader)
        {
            return new Stanica
            {
                ID_stanice = (int)reader["ID_stanice"],
                Naziv = reader["Naziv"].ToString(),
                Lokacija = reader["Lokacija"].ToString()
            };
        }
    }
}
