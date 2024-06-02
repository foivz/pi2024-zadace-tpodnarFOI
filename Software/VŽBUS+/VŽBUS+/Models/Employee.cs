using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VŽBUS_.Models
{
    public class Employee : User
    {
        public string Position { get; set; }

        public void ManageData(object data)
        {

        }

        public List<Report> GenerateReports()
        {
            return new List<Report>();
        }
    }
}
