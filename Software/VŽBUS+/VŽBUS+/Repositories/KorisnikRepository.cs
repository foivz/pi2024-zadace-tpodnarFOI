using System.Collections.Generic;
using System.Data.SqlClient;
using DBLayer;
using VŽBUS_.Models;

namespace VŽBUS_.Repositories
{
    public static class KorisnikRepository
    {
        public static List<Korisnik> GetKorisnici()
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            string sql = "SELECT * FROM Korisnik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Korisnik korisnik = CreateObject(reader);
                korisnici.Add(korisnik);
            }
            reader.Close();
            DB.CloseConnection();
            return korisnici;
        }

        private static Korisnik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID_korisnika"].ToString());
            string korisnickoIme = reader["Korisničko_ime"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            string email = reader["Email"].ToString();
            string telefon = reader["Telefon"].ToString();
            var korisnik = new Korisnik
            {
                ID_korisnika = id,
                Korisničko_ime = korisnickoIme,
                Lozinka = lozinka,
                Email = email,
                Telefon = telefon
            };
            return korisnik;
        }
    }
}
