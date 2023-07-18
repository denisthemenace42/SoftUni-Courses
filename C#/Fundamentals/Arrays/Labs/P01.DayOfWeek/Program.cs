using System;

namespace P01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputDay = int.Parse(Console.ReadLine());
            string[] week = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            
                if (inputDay <= 0 || inputDay > week.Length)
                {
                    Console.WriteLine("Invalid day!");
                }
                else
                {
                    Console.Write(week[inputDay-1]);
                }
        }
    }
}
