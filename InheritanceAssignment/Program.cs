using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Program : IQuittable
    {
        static void Main(string[] args)
        {
            Employee p = new Employee() { FirstName = "Ethan", LastName = "Buss" };
            p.SayName();
        }
        void IQuittable.Quit()
        {
            //Have no idea if this is right ^^
        }
    }
}
