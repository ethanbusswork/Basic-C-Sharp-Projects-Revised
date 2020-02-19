using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em0 = new Employee() { FirstName = "John", LastName = "Smith", ID = 001 };
            Employee em1 = new Employee() { FirstName = "James", LastName = "Palmer", ID = 002 };
            Employee em2 = new Employee() { FirstName = "Joe", LastName = "Willis", ID = 003 };
            Employee em3 = new Employee() { FirstName = "Jacob", LastName = "Davis", ID = 004 };
            Employee em4 = new Employee() { FirstName = "Kate", LastName = "Wilson", ID = 005 };
            Employee em5 = new Employee() { FirstName = "Frank", LastName = "Jackson", ID = 006 };
            Employee em6 = new Employee() { FirstName = "Mike", LastName = "Franks", ID = 007 };
            Employee em7 = new Employee() { FirstName = "Joe", LastName = "Kane", ID = 008 };
            Employee em8 = new Employee() { FirstName = "Alex", LastName = "Menkoff", ID = 009 };
            Employee em9 = new Employee() { FirstName = "Vlad", LastName = "Prudovka", ID = 010 };


            List<Employee> employees = new List<Employee>() { em0, em1, em2, em3, em4, em5, em6, em7, em8, em9 };

            foreach (Employee employee in employees)
            {
                Console.WriteLine("\nName: " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("ID: " + employee.ID);
            }

            List<Employee> filteredEmployees = employees.Where(x => x.FirstName == "Joe").ToList();

            //foreach (Employee employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        filteredEmployees.Add(employee);
            //    }
            //}

            Console.WriteLine("\n\n<<<<< Filtered Employees >>>>>");

            foreach (Employee employee in filteredEmployees)
            {
                Console.WriteLine("\nName: " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("ID: " + employee.ID);
            }



            Console.Read();
        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
    }
}
