using System;

namespace P02.SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int restDays = int.Parse(Console.ReadLine());
            int workDays = 365 - restDays;
            int playTime = (workDays * 63) + (restDays * 127);
            int difference = Math.Abs(30000 - playTime);
            int hours = difference / 60;
            double minutes = difference % 60;
            if ( playTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
