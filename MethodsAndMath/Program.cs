using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndMath
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] Addition");
            Console.WriteLine("[2] Subtraction");
            Console.WriteLine("[3] Multiplication");
            Console.WriteLine("[4] Division");
            Console.WriteLine("\nSelect Math Operation:");
            int menuSelect = Convert.ToInt32(Console.ReadLine());

            if (menuSelect == 1)
            {
                Math n = new Math();

                Console.WriteLine("\nSELECTED: Addition");

                Console.WriteLine("\nEnter first whole number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter second whole number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nAdding " + num1 + " and " + num2 + ":");
                int ret = n.Addition(num1, num2);
                Console.WriteLine("Your answer is: " + ret);
            }
            else if (menuSelect == 2)
            {
                Math n = new Math();

                Console.WriteLine("\nSELECTED: Subtraction");

                Console.WriteLine("\nEnter first whole number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter second whole number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nAdding " + num1 + " and " + num2 + ":");
                int ret = n.Subtraction(num1, num2);
                Console.WriteLine("Your answer is: " + ret);
            }
            else if (menuSelect == 3)
            {
                Math n = new Math();

                Console.WriteLine("\nSELECTED: Multiplication");

                Console.WriteLine("\nEnter first whole number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter second whole number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nAdding " + num1 + " and " + num2 + ":");
                int ret = n.Multiplication(num1, num2);
                Console.WriteLine("Your answer is: " + ret);
            }
            else if (menuSelect == 4)
            {
                Math n = new Math();

                Console.WriteLine("\nSELECTED: Division");

                Console.WriteLine("\nEnter first whole number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter second whole number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nAdding " + num1 + " and " + num2 + ":");
                int ret = n.Division(num1, num2);
                Console.WriteLine("Your answer is: " + ret);
            }
            else
            {
                Console.WriteLine("\nYou did not enter a valid menu item.");
            }
            Console.Read();
        }
    }
}
