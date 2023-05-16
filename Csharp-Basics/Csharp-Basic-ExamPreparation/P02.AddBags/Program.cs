using System;

namespace P02.CatWalking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesWalking = int.Parse(Console.ReadLine());
            int dayCount = int.Parse(Console.ReadLine()) * minutesWalking;
            double catCalories = int.Parse(Console.ReadLine()) / 2;
            double caloriesBurned = dayCount * 5;

            if (caloriesBurned >= catCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurned}.");
            }

            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurned}.");
            }
        }
    }
}
