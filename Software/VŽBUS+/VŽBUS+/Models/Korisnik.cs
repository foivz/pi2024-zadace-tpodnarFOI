using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VŽBUS_.Models
{
    public class Korisnik
    {
        public int ID_korisnika { get; set; }
        public string Korisničko_ime { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
    }
}
