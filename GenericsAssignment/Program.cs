using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> strings = new Employee<string>();
            strings.Things = new List<string>();

            strings.Things.Add("Car");
            strings.Things.Add("Desk");
            strings.Things.Add("Keys");

            Employee<int> ints = new Employee<int>();
            ints.Things = new List<int>();

            ints.Things.Add(5);
            ints.Things.Add(6);
            ints.Things.Add(7);
            ints.Things.Add(8);

            foreach (string s in strings.Things)
            {
                Console.WriteLine(s);
            }
            foreach (int i in ints.Things)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
