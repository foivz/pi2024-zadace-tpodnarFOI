using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VŽBUS_.Models;

namespace VŽBUS_.Repositories
{
    public static class PassengerRepository
    {
        public static Passenger GetPassenger(int id)
        {
            Passenger passenger = null;
            string sql = $"SELECT * FROM Passengers WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                passenger = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return passenger;
        }

        public static List<Passenger> GetPassengers()
        {
            List<Passenger> passengers = new List<Passenger>();
            string sql = "SELECT * FROM Passengers";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Passenger passenger = CreateObject(reader);
                passengers.Add(passenger);
            }
            reader.Close();
            DB.CloseConnection();
            return passengers;
        }

        private static Passenger CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();

            var passenger = new Passenger
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password
            };
            return passenger;
        }
    }
}
