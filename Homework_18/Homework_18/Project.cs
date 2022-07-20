using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_18
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public int Budget { get; set; }
        public int ClientID { get; set; }
        public DateTime StartedDate { get; set; }
        public EmployeeProject EmployeeProject { get; set; }
    }
}
