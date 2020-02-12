using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInsuranceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<<<<< CAR INSURANCE QUALIFICATION APP >>>>>>>>>>");
            Console.WriteLine("What is your age?:");
            string customerAge = Console.ReadLine();
            int customerAge_INT = Convert.ToInt32(customerAge);
            bool customerAge_bool = customerAge_INT > 15;
            Console.WriteLine("Have you ever had a DUI? (True/False):");
            string duiCount = Console.ReadLine();
            bool duiQual_bool = Convert.ToBoolean(duiCount);
            Console.WriteLine("How many speeding tickets do you have on record?:");
            string speedingTickets = Console.ReadLine();
            int speedingTickets_INT = Convert.ToInt32(speedingTickets);
            bool speedingQual_bool = speedingTickets_INT < 4;
            bool qualified = customerAge_bool && speedingQual_bool ^ duiQual_bool;
            Console.WriteLine("Qualified for Car Insurance?: " + qualified);
            Console.Read();
        }
    }
}
