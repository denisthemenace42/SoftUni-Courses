using System;

namespace P07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine();
            if( hour >=10 && hour <= 18)
            {
                if(dayOfTheWeek != "Sunday")
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
