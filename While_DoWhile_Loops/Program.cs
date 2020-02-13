using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_DoWhile_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a color:");
            string guessedColor = Console.ReadLine();
            bool guessedCorrect = false;

            //while (!guessedCorrect)
            //{
            //    switch (guessedColor)
            //    {
            //        case "Red":
            //            Console.WriteLine("You guessed Red, that is incorrect, try again");
            //            Console.WriteLine("Guess a color:");
            //            guessedColor = Console.ReadLine();
            //            break;

            //        case "Orange":
            //            Console.WriteLine("You guessed Orange, that is correct!");
            //            guessedCorrect = true;
            //            break;

            //        case "Green":
            //            Console.WriteLine("You guessed Green, that is incorrect, try again");
            //            Console.WriteLine("Guess a color:");
            //            guessedColor = Console.ReadLine();
            //            break;

            //        case "Blue":
            //            Console.WriteLine("You guessed Blue, that is incorrect, try again");
            //            Console.WriteLine("Guess a color:");
            //            guessedColor = Console.ReadLine();
            //            break;

            //        case "Purple":
            //            Console.WriteLine("You guessed Purple, that is incorrect, try again");
            //            Console.WriteLine("Guess a color:");
            //            guessedColor = Console.ReadLine();
            //            break;

            //        default:
            //            Console.WriteLine("That's not a valid color, try again");
            //            Console.WriteLine("Guess a color:");
            //            guessedColor = Console.ReadLine();
            //            break;
            //    }
            //}
            //Console.Read();


            do
            {
                switch (guessedColor)
                {
                    case "Red":
                        Console.WriteLine("You guessed Red, that is incorrect, try again");
                        Console.WriteLine("Guess a color:");
                        guessedColor = Console.ReadLine();
                        break;

                    case "Orange":
                        Console.WriteLine("You guessed Orange, that is correct!");
                        guessedCorrect = true;
                        break;

                    case "Green":
                        Console.WriteLine("You guessed Green, that is incorrect, try again");
                        Console.WriteLine("Guess a color:");
                        guessedColor = Console.ReadLine();
                        break;

                    case "Blue":
                        Console.WriteLine("You guessed Blue, that is incorrect, try again");
                        Console.WriteLine("Guess a color:");
                        guessedColor = Console.ReadLine();
                        break;

                    case "Purple":
                        Console.WriteLine("You guessed Purple, that is incorrect, try again");
                        Console.WriteLine("Guess a color:");
                        guessedColor = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("That's not a valid color, try again");
                        Console.WriteLine("Guess a color:");
                        guessedColor = Console.ReadLine();
                        break;
                }
            }
            while (!guessedCorrect);
            
            Console.Read();
        }
    }
}
