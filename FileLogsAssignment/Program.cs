using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileLogsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int appendText = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\ethan\Documents\GitHub\Basic-C-Sharp-Projects-Revised\FileLogsAssignment\log.txt", true))
            {
                file.WriteLine(appendText.ToString());
            }

            Console.WriteLine(File.ReadAllText(@"C:\Users\ethan\Documents\GitHub\Basic-C-Sharp-Projects-Revised\FileLogsAssignment\log.txt"));

            Console.Read();
        }
    }
}
