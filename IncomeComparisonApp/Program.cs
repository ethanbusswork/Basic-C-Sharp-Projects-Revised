using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<<<<<ANONYMOUS INCOME COMPARISON APPLICATION>>>>>>>>>>");
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly Rate:");
            string hourlyRatePerson1 = Console.ReadLine();
            int hourlyRatePerson1INT = Convert.ToInt32(hourlyRatePerson1);
            Console.WriteLine("Hours worked per week:");
            string hoursWorkedPerson1 = Console.ReadLine();
            int hoursWorkedPerson1INT = Convert.ToInt32(hoursWorkedPerson1);
            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Rate:");
            string hourlyRatePerson2 = Console.ReadLine();
            int hourlyRatePerson2INT = Convert.ToInt32(hourlyRatePerson2);
            Console.WriteLine("Hours worked per week:");
            string hoursWorkedPerson2 = Console.ReadLine();
            int hoursWorkedPerson2INT = Convert.ToInt32(hoursWorkedPerson2);
            int totalPerson1 = (hoursWorkedPerson1INT * 52) * hourlyRatePerson1INT;
            int totalPerson2 = (hoursWorkedPerson2INT * 52) * hourlyRatePerson2INT;
            Console.WriteLine("Annual Salary of Person 1: " + totalPerson1);
            Console.WriteLine("Annual Salary of Person 2: " + totalPerson2);
            bool whichIsGreater = totalPerson1 > totalPerson2;
            Console.WriteLine("Does Person 1 make more money per year before taxes than Person 2: " + whichIsGreater);
            Console.Read();
        }
    }
}
