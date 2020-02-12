using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<<<<< PACKAGE EXPRESS APP >>>>>>>>>>");
            Console.WriteLine("What is the package's weight in pounds? (Ex: 1.2)");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("What is the width of the package in inches? (Ex: 45.2");
            decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("What is the height of the package in inches? (Ex: 45.2");
            decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("What is the length of the package in inches? (Ex: 45.2");
            decimal packageLength = Convert.ToDecimal(Console.ReadLine());

            if (packageWidth + packageHeight + packageLength > 50)
            {
                Console.WriteLine("Package too large to be shipped by Package Express. We're sorry for the inconvienence.");
                Console.Read();
            }
            else
            {
                decimal packageTotal = (packageWidth * packageHeight * packageLength * packageWeight) / 100;
                Console.WriteLine("Your estimated total for shipping is: $" + packageTotal);
                Console.Read();
            }
        }
    }
}
