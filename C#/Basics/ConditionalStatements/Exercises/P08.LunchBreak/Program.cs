using System;

namespace P08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int lenghtMovie = int.Parse(Console.ReadLine());
            int lenghtBreak = int.Parse(Console.ReadLine());

            double lunch = lenghtBreak * 1.0 / 8;
            double rest = lenghtBreak * 1.0 / 4;
            double totalTime = lenghtBreak - lunch - rest;

            if (totalTime >= lenghtMovie)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(totalTime - lenghtMovie)} minutes free time.");
            }
            else  
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(lenghtMovie - totalTime)} more minutes.");
            }
        }
        
    }
}



