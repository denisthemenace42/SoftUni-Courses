using System;

namespace P08.CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfTheWeek = Console.ReadLine();
            if ( dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Friday")
            {
                Console.WriteLine("12");
            }
            else if (dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday")
            {
                Console.WriteLine("14");
            }
            else
            {
                Console.WriteLine("16");
            }
        }
    }
}
