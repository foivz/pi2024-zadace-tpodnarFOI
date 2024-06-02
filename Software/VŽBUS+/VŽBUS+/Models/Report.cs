using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VŽBUS_.Models
{
    public class Report
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public string Content { get; set; }
        public DateTime GeneratedDate { get; set; }
    }
}
