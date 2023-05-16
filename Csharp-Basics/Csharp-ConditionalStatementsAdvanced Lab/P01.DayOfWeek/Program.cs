using System;

namespace P01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfTheWeek = int.Parse(Console.ReadLine());
            if (dayOfTheWeek == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (dayOfTheWeek == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (dayOfTheWeek == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (dayOfTheWeek == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (dayOfTheWeek == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (dayOfTheWeek == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (dayOfTheWeek == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
