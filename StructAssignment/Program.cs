using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number();
            num1.Amount = 2.5m;

            Console.WriteLine(num1.Amount);

            Console.Read();
        }

        public struct Number
        {
            public decimal Amount { get; set; }

        }
    }
}
