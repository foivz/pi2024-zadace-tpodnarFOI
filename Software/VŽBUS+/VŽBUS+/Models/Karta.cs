using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VŽBUS_.Models
{
    public class Karta
    {
        public int ID_karte { get; set; }
        public int ID_korisnika { get; set; }
        public int ID_linije { get; set; }
        public DateTime Datum_izdavanja { get; set; }
        public TimeSpan Vrijeme_izdavanja { get; set; }
        public string Sjedalo { get; set; }
    }
}
