using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_164
{
    static class Program
    {
        static void Main(string[] args)
        {
            Method1 m1 = new Method1();
            int result2;

            Console.WriteLine("Enter a number to be divided:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the denominator to divide by:(Default: 2)");
            string num2_string = Console.ReadLine();

            if (num2_string == "")
            {
                m1.Div2(num1);
            }
            else
            {
                int num2 = Convert.ToInt32(num2_string);
                m1.Div2(num1, num2);
            }

            m1.Mult(out result2);
            Console.WriteLine("Your answer is: " + result2);
            
            Console.Read();
        }
        
    }

    class Method1
    {
        public void Div2(int num1)
        {
            int result;

            result = num1 / 2;

            Console.WriteLine(num1 + " divided by 2 is: " + result);
        }

        public void Div2(int num1, int num2)
        {
            int result;

            result = num1 / num2;

            Console.WriteLine(num1 + " divided by " + num2 + " is: " + result);
        }

        public void Mult(out int result2)
        {
            Console.WriteLine("Enter a number to multiply by 2:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            result2 = num3 * 2;
        }
    }
}
