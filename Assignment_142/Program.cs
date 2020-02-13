using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_142
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] stringArray1 = { "Lorem ", "Ipsum ", "Dolor ", "Sit ", "Amet " };

            //Console.WriteLine("Input text to be added to 'stringArray1':");
            //string inputText1 = Console.ReadLine();

            //for (int i = 0; i < stringArray1.Length; i++)
            //{
            //    Console.WriteLine(stringArray1[i] + inputText1);
            //}
            //Console.Read();

            ///////////////////////////////////////////////////////////////////////////////////////

            //for (int i = 0; i < i + 1; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            ///////////////////////////////////////////////////////////////////////////////////////

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            ///////////////////////////////////////////////////////////////////////////////////////

            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            ///////////////////////////////////////////////////////////////////////////////////////

            //List<string> stringList1 = new List<string>();
            //stringList1.Add("He stepped gingerly onto the bridge knowing that enchantment awaited on the other side.");
            //stringList1.Add("There is a fly in the car with us.");
            //stringList1.Add("People generally approve of dogs eating cat food but not cats eating dog food.");
            //stringList1.Add("Look on top of the refrigerator for the key.");
            //stringList1.Add("The fact that there's a stairway to heaven and a highway to hell explains life well.");

            //Console.WriteLine("Input text to be searched in 'stringList1':");
            //string searchText1 = Console.ReadLine().ToLower();

            //for (int i = 0; i < stringList1.Count; i++)
            //{
            //    if (stringList1[i].ToLower().Contains(searchText1))
            //    {
            //        Console.WriteLine(stringList1[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("The text you entered is not found in string #" + (i + 1).ToString());
            //    }
            //}
            //Console.Read();

            ///////////////////////////////////////////////////////////////////////////////////////

            List<string> stringList2 = new List<string>();
            stringList2.Add("He stepped gingerly onto the bridge knowing that enchantment awaited on the other side.");
            stringList2.Add("There is a fly in the car with us.");
            stringList2.Add("The fact that there's a stairway to heaven and a highway to hell explains life well.");
            stringList2.Add("Look on top of the refrigerator for the key.");
            stringList2.Add("The fact that there's a stairway to heaven and a highway to hell explains life well.");

            List<string> stringList3 = new List<string>();

            List<string> stringList4 = new List<string>();

            foreach (string sentence1 in stringList2)
            {
                if (stringList3.Contains(sentence1))
                {
                    stringList4.Add(sentence1);
                }
                else
                {
                    stringList3.Add(sentence1);
                }
            }

            foreach (string listitem in stringList3)
            {
                Console.WriteLine(listitem + ": does not appear twice.");
            }

            foreach (string listitem2 in stringList4)
            {
                Console.WriteLine(listitem2 + ": does appear twice.");
            }

            Console.Read();
        }
    }
}
