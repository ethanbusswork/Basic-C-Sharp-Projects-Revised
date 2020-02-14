using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] Multiply an integer method");
            Console.WriteLine("[2] Multiply a decimal method");
            Console.WriteLine("[3] Multiply a string method");
            Console.WriteLine("\nSelect Math Operation:");
            int menuSelect = Convert.ToInt32(Console.ReadLine());

            if (menuSelect == 1)
            {
                Overloads n = new Overloads();

                Console.WriteLine("\nSELECTED: Multiply an integer method");

                Console.WriteLine("\nEnter a whole number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nMultiplying " + num1 + " by 2");
                int ret = n.Multiply(num1);
                Console.WriteLine("Your answer is: " + ret);
            }
            else if (menuSelect == 2)
            {
                Overloads n = new Overloads();

                Console.WriteLine("\nSELECTED: Multiply a decimal method");

                Console.WriteLine("\nEnter a whole number:");
                decimal num1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("\nMultiplying " + num1 + " by 2");
                decimal ret = n.Multiply(num1);
                Console.WriteLine("Your answer is: " + ret);
            }
            else if (menuSelect == 3)
            {
                Overloads n = new Overloads();

                Console.WriteLine("\nSELECTED: Multiply a string method");

                Console.WriteLine("\nEnter a whole number:");
                string num1 = Console.ReadLine();

                Console.WriteLine("\nMultiplying " + num1 + " by 2");
                string ret = n.Multiply(num1);
                Console.WriteLine("Your answer is: " + ret);
            }
            else
            {
                Console.WriteLine("You did not enter a valid menu item");
            }

            Console.Read();
        }
    }
}
