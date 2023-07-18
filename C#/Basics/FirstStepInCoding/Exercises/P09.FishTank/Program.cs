using System;

namespace P09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int capacity = lenght * width * height;
            double litreCapacity = capacity * 0.001;
            double percentTaken = percent / 100;
            double litreRequired = litreCapacity * (1 - percentTaken);

            Console.WriteLine(litreRequired);

        }
    }
}
