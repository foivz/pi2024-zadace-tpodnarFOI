using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VŽBUS_.Models
{
    public class BusLine
    {
        public int Id { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public string Schedule { get; set; }

        public string GetBusLineSchedule()
        {
            return Schedule;
        }

        public bool ReserveSeat(Passenger passenger, int seatNumber)
        {
            return true;
        }
    }
}
