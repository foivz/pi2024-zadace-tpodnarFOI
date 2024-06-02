using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VŽBUS_.Models
{
    public class Linija
    {
        public int ID_linije { get; set; }
        public string Polazište { get; set; }
        public string Odredište { get; set; }
        public TimeSpan Vrijeme_polaska { get; set; }
        public TimeSpan Vrijeme_dolaska { get; set; }
    }
}
