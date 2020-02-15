using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionalInputs n = new OptionalInputs();

            Console.WriteLine("<<<<<<<<<< OPTIONAL INPUTS APP >>>>>>>>>>");
            Console.WriteLine("\nYou have the option of entering two inputs.");
            Console.WriteLine("The first input however, is mandatory.");
            Console.WriteLine("\nFirst input:");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second input (Default: 2):");

            string num2_string = Console.ReadLine();

            if (num2_string == "")
            {
                int ret = n.Mult(num1);
                Console.WriteLine("Multiplying...");
                Console.WriteLine("Your answer is: " + ret);
            }
            else if (num2_string != "")
            {
                int num2 = Convert.ToInt32(num2_string);
                int ret = n.Mult(num1, num2);
                Console.WriteLine("Multiplying...");
                Console.WriteLine("Your answer is: " + ret);
            }
            Console.Read();
        }
        class OptionalInputs
        {
            public int Mult(int num1, int num2 = 2)
            {
                int result;

                result = num1 * num2;

                return result;
            }
        }
    }
}
