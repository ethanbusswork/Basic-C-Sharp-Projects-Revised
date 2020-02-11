using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to mulitply by 50:");
            string multiplyBy50 = Console.ReadLine();
            int mult50 = Convert.ToInt32(multiplyBy50);
            Console.WriteLine(mult50 * 50);
            Console.WriteLine("Enter a number to add 25 to:");
            string add25to = Console.ReadLine();
            int add25toint = Convert.ToInt32(add25to);
            Console.WriteLine(add25toint + 25);
            Console.WriteLine("Enter a number to divide by 12.5:");
            string divideByTwelveFive = Console.ReadLine();
            decimal div12 = Convert.ToDecimal(divideByTwelveFive);
            Console.WriteLine(div12 / 12.5m);
            Console.WriteLine("Enter a number to test if greater than 50:");
            string isGreater50 = Console.ReadLine();
            int isGr50 = Convert.ToInt32(isGreater50);
            bool Is50GreaterThanNum = 50 < isGr50;
            Console.WriteLine(Is50GreaterThanNum.ToString());
            Console.WriteLine("Enter a number to divide by 7 and print remainder:");
            string divideby7 = Console.ReadLine();
            int Div7 = Convert.ToInt32(divideby7);
            Console.WriteLine(Div7 / 7);
            Console.WriteLine("Remainder: " + Div7 % 7);
            Console.Read();
        }
    }
}
