using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);

            Console.WriteLine(intList[0]);
            Console.Read();

            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 10;
            //numArray[2] = 20;
            //numArray[3] = 40;
            //numArray[4] = 80;

            //int[] numArray1 = new int[] { 5, 10, 20, 40, 80 };

            //int[] numArray2 = { 5, 10, 20, 40, 80 };

            //Console.WriteLine(numArray[3]);
            //Console.Read();
        }
    }
}
