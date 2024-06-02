using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VŽBUS_.Models
{
    public class Bus
    {
        public int Id { get; set; }
        public string NumberPlate { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }

        public void UpdateLocation(string location)
        {
            Location = location;
        }
    }
}
