using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VŽBUS_.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public Passenger Passenger { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
