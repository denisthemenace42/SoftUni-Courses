using System;

namespace P07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int waterCapacity = 255;
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                int litersOfWater = int.Parse(Console.ReadLine());

                if (sum + litersOfWater > waterCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                   
                }
                else 
                {
                    sum += litersOfWater;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
