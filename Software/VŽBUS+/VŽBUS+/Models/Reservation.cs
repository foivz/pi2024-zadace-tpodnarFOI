using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VŽBUS_.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public Passenger Passenger { get; set; }
        public BusLine BusLine { get; set; }
        public int SeatNumber { get; set; }
        public DateTime Date { get; set; }
    }
}
