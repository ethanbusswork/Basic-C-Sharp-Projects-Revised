using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee p = new Employee() { FirstName = "Ethan", LastName = "Buss" };
            p.SayName();
        }
    }
}
