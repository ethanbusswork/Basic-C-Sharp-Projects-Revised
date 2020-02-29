﻿using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\n Welcome back, {uName}. Today is {date}. ";
            Console.WriteLine(msg);

            string path = @"C:\Users\ethan\Documents\GitHub\Basic-C-Sharp-Projects-Revised\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores: ");
            foreach (string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\n\nAverage score: " + avgScore);


            Console.Read();
        }
    }
}
