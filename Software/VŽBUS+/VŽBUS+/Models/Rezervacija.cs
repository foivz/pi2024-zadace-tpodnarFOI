using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VŽBUS_.Models
{
    public class Rezervacija
    {
        public int ID_rezervacije { get; set; }
        public int ID_korisnika { get; set; }
        public int ID_linije { get; set; }
        public DateTime Datum_rezervacije { get; set; }
        public TimeSpan Vrijeme_rezervacije { get; set; }
        public string Sjedalo { get; set; }
    }
}
