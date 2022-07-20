using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_18
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HiredDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int OfficeId { get; set; }
        public List<Office> Office { get; set; }
        public int TitleId { get; set; }
        public List<Title> Title { get; set; }        
        public EmployeeProject EmployeeProject { get; set; }        
    }
}
