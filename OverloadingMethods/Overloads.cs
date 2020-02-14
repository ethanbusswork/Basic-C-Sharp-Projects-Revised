using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    public class Overloads
    {
        public int Multiply(int num1)
        {
            int result;

            result = num1 * 2;

            return result;
        }

        public decimal Multiply(decimal num1)
        {
            decimal result;

            result = num1 * 2;

            return result;
        }
        public string Multiply(string num1)
        {
            int result;

            int num1_converted = Convert.ToInt32(num1);

            result = num1_converted * 2;

            return result.ToString();
        }
    }
}
