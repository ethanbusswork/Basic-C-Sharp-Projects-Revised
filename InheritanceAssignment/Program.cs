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
            Employee p = new Employee() { FirstName = "Ethan", LastName = "Buss", ID = 0001 };
            Employee a = new Employee() { FirstName = "Jim", LastName = "Halpert", ID = 0002 };
            List<Employee> employees = new List<Employee>();
            employees.Add(p);
            employees.Add(a);

            foreach (Employee employee in employees)
            {
                Console.WriteLine("\nFirst Name: " + employee.FirstName + "\nLast Name: " + employee.LastName + "\nID: " + employee.ID);
            }
            

            Console.WriteLine("\nEmployee '" + p.FirstName + " " + p.LastName + "' and '" + a.FirstName + " " + a.LastName + "' have equal ID's: " + (p.ID == a.ID));
            
            Console.Read();
        }
        void IQuittable.Quit()
        {
            //Have no idea if this is right ^^
        }
    }
}
