using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_18
{
    public class EmployeeProject
    {
        public int EmployeeProjectId { get; set; }
        public int Rate { get; set; }
        public DateTime StartedDate { get; set; }
        public int EmployeeId { get; set; }
        public List<Employee> Employee { get; set; }
        public int ProjectId { get; set; }
        public List<Project> Project { get; set; }
    }
}
