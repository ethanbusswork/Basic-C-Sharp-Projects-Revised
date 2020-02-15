using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            voidMethod n = new voidMethod();

            Console.WriteLine("<<<<<<<<<< VOID METHOD APP >>>>>>>>>>");
            Console.WriteLine("\nEnter first number: ");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter second number: ");

            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMultiplying...");

            //n.Void(num1, num2);
            n.Void(num1: num1, num2: num2);

        }
    }
    class voidMethod
    {
        public void Void(int num1, int num2)
        {
            int result;

            result = num1 * num2;

            Console.WriteLine("Your answer is: " + result);
            
            Console.Read();
        }
        
    }
}
