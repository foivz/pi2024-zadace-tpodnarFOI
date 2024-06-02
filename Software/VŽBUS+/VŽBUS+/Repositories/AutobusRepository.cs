using System.Collections.Generic;
using System.Data.SqlClient;
using DBLayer;
using VŽBUS_.Models;

namespace VŽBUS_.Repositories
{
    public static class AutobusRepository
    {
        public static List<Autobus> GetAutobusi()
        {
            List<Autobus> autobusi = new List<Autobus>();
            string sql = "SELECT * FROM Autobus";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Autobus autobus = CreateObject(reader);
                autobusi.Add(autobus);
            }
            reader.Close();
            DB.CloseConnection();
            return autobusi;
        }

        public static void InsertAutobus(Autobus autobus)
        {
            string sql = $"INSERT INTO Autobus (Registracijski_broj, Kapacitet) VALUES ('{autobus.Registracijski_broj}', {autobus.Kapacitet})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateAutobus(Autobus autobus)
        {
            string sql = $"UPDATE Autobus SET Registracijski_broj = '{autobus.Registracijski_broj}', Kapacitet = {autobus.Kapacitet} WHERE ID_autobusa = {autobus.ID_autobusa}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteAutobus(int id)
        {
            string sql = $"DELETE FROM Autobus WHERE ID_autobusa = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        private static Autobus CreateObject(SqlDataReader reader)
        {
            return new Autobus
            {
                ID_autobusa = (int)reader["ID_autobusa"],
                Registracijski_broj = reader["Registracijski_broj"].ToString(),
                Kapacitet = (int)reader["Kapacitet"]
            };
        }
    }
}
