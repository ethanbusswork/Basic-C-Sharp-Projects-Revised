using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayStrings = { "Hello!", "Hi!", "Hey" };
            int arrayStringsLength = arrayStrings.Length;
            Console.WriteLine("Select an index in the Strings Array: 0 - " + (arrayStringsLength - 1));
            int arrayStringsSelect = Convert.ToInt32(Console.ReadLine());
            if (arrayStringsSelect > (arrayStringsLength - 1))
            {
                Console.WriteLine("Invalid index code, try again");
            }
            else
            {
                Console.WriteLine(arrayStrings[arrayStringsSelect]);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////

            int[] arrayInt = { 15, 30, 45, 60, 75, 90 };
            int arrayIntLength = arrayInt.Length;
            Console.WriteLine("Select an index in the Integer Array: 0 - " + (arrayIntLength - 1));
            int arrayIntSelect = Convert.ToInt32(Console.ReadLine());
            if (arrayIntSelect > (arrayIntLength - 1))
            {
                Console.WriteLine("Invalid index code, try again");
            }
            else
            {
                Console.WriteLine(arrayInt[arrayIntSelect]);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////

            List<string> stringList = new List<string>();
            stringList.Add("List element 1");
            stringList.Add("List element 2");
            stringList.Add("List element 3");
            stringList.Add("List element 4");
            int stringListLength = stringList.Count;
            Console.WriteLine("Select an index from the String list: 0 - " + (stringListLength - 1));
            int stringListSelect = Convert.ToInt32(Console.ReadLine());
            if (stringListSelect > (stringListLength - 1))
            {
                Console.WriteLine("Invalid index code, try again");
            }
            else
            {
                Console.WriteLine(stringList[stringListSelect]);
            }



            Console.Read();
        }
    }
}
