using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your daily report client!");
            Console.WriteLine("What course are you on?:");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number are you on?:");
            string pageNumber = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer 'True' or 'False'");
            string assistStatus = Console.ReadLine();
            bool aStat = Convert.ToBoolean(assistStatus);
            Console.WriteLine("Did you have any positive experiences you'd like to share? Please give specifics:");
            string posExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific:");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?:");
            string hoursWorked = Console.ReadLine();
            int hrsWrkd = Convert.ToInt32(hoursWorked);
            Console.WriteLine("Thank you for your answers. An intructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
