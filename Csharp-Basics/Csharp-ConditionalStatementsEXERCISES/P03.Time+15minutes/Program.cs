using System;

namespace P03.Time_15minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += hours * 60;
            minutes += 15;

            hours = minutes / 60;
            minutes %= 60;
            if(hours == 24)
            {
                Console.WriteLine($"0:{minutes:D2}");
            }
            
            
            else 
            {
                Console.WriteLine($"{hours}:{minutes:D2}");
            }
               
        }
    }
}
