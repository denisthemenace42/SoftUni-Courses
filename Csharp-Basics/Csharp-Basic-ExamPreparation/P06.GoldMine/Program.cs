using System;

namespace P06.GoldMine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int location = int.Parse(Console.ReadLine());
            double goldPerDay = 0;
            int dayCount = 0;
            
            for (int i=0; i<location; i++)
            {
                double sum = 0;
                goldPerDay = double.Parse(Console.ReadLine());
                dayCount = int.Parse(Console.ReadLine());
                for (int k = 0; k< dayCount; k++)
                {
                    double gold = double.Parse(Console.ReadLine());
                    sum += gold;
                }
                sum /= dayCount;
                if (sum >= goldPerDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {sum:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {goldPerDay - sum:f2} gold.");
                }
            }
        }
    }
}
