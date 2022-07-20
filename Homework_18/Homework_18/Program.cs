using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //    var connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Homework18;Integrated Security=True";
            //    var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            //    var options = optionsBuilder
            //        .UseSqlServer(connectionString)
            //        .Options;
            using (var context = new ApplicationContext(@"Data Source=.\SQLEXPRESS;Initial Catalog = Homework18;Integrated Security=True;"))
            {             
            }
        }
    }
}
