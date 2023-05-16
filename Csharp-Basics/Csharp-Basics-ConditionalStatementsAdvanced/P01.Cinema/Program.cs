using System;

namespace P01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cinemaType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double income = 0;

            if (cinemaType == "Premiere")
            {
                income = rows * columns * 12.00;
            }
            else if (cinemaType == "Normal")
            {
                income = rows * columns * 7.50;
            }
            else
            {
                income = rows * columns * 5.00;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
