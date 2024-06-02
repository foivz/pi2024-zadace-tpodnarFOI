using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DBLayer;
using VŽBUS_.Models;

namespace VŽBUS_.Repositories
{
    public static class LinijaRepository
    {
        public static List<Linija> GetLinije()
        {
            List<Linija> linije = new List<Linija>();
            string sql = "SELECT * FROM Linija";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Linija linija = CreateObject(reader);
                linije.Add(linija);
            }
            reader.Close();
            DB.CloseConnection();
            return linije;
        }

        public static List<Linija> SearchLinije(string searchTerm)
        {
            List<Linija> linije = new List<Linija>();
            string sql = $"SELECT * FROM Linija WHERE Odredište LIKE '%{searchTerm}%' OR Polazište LIKE '%{searchTerm}%'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Linija linija = CreateObject(reader);
                linije.Add(linija);
            }
            reader.Close();
            DB.CloseConnection();
            return linije;
        }

        private static Linija CreateObject(SqlDataReader reader)
        {
            return new Linija
            {
                ID_linije = (int)reader["ID_linije"],
                Polazište = reader["Polazište"].ToString(),
                Odredište = reader["Odredište"].ToString(),
                Vrijeme_polaska = (TimeSpan)reader["Vrijeme_polaska"],
                Vrijeme_dolaska = (TimeSpan)reader["Vrijeme_dolaska"]
            };
        }
    }
}
