using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VŽBUS_.Models
{
    public class Passenger : User
    {
        public string Email { get; set; }
        public string Phone { get; set; }

        public bool MakeReservation(BusLine busLine, int seatNumber)
        {
            return true;
        }

        public void GiveFeedback(string feedback)
        {

        }
    }
}
