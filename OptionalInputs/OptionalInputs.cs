using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalInputs
{
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
