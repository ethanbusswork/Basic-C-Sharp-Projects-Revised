using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_235
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Math m = new Math();

                DateTime currentTime = DateTime.Now;
                int currentYear = Convert.ToInt32(currentTime.Year);

                int age = 0;
                bool validAnswer = false;
                while (!validAnswer)
                {
                    Console.WriteLine("Enter your age!");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer)
                    {
                        Console.WriteLine("Please enter digits only, no decimals.");
                    }
                }
                if (age <= 0)
                {
                    throw new negativeAgeException();
                }


                int result = m.BirthYear(age, currentYear);

                Console.WriteLine("Your birth year was ~" + result.ToString());

            }
            catch (negativeAgeException)
            {
                Console.WriteLine("You did not enter a valid age, use positive integers.");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occured, please contact system administrator.");
                return;
            }
            finally
            {
                Console.Read();
            }
        }
    }

    public class Math
    {
        public int BirthYear(int age, int currentYear)
        {
            int birthYear = currentYear - age;
            return birthYear;
        }
    }

    public class negativeAgeException : Exception
    {
        public negativeAgeException()
            : base() { }
        public negativeAgeException(string message)
            : base(message) { }
    }
}
