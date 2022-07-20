using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_18
{
    public class Office
    {
        public int OfficeId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public Employee Employee { get; set; }
    }
}
