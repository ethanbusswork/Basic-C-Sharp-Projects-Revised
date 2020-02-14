using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int>{ 10, 20, 30, 40, 50, 60, 70, 80, 90 };

                Console.WriteLine("Pick a number from 1 - 9:");

                int input = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < intList.Count; i++)
                {
                    Console.WriteLine("Dividing " + intList[i] + " by " + input + ". The answer is: " + (intList[i] / input));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
