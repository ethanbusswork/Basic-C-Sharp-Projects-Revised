using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace EnumsDaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day of the week:");
            string userInput = Console.ReadLine();

            try
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);

                if (day == DaysOfTheWeek.Friday)
                {
                    Console.WriteLine("It's Friday! WOOHOO!");
                }
                else
                {
                    Console.WriteLine("Ugh, it's not Friday yet?!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed");
                Console.WriteLine("Please print actual day of week");

            }
            finally
            {
                Console.Read();
            }
            
        }
        public enum DaysOfTheWeek
        {
            None,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }




}
