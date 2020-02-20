using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime rightNow = new DateTime();
            DateTime addedHours = new DateTime();
            Console.WriteLine(DateTime.Now + "\n");

            Console.WriteLine("Please enter an integer");
            double addHour = Convert.ToInt32(Console.ReadLine());

            rightNow = DateTime.Now;

            addedHours = rightNow.AddHours(addHour);

            Console.WriteLine("The time in {0} hours is {1}", addHour, addedHours);

            Console.Read();
        }
    }
}
