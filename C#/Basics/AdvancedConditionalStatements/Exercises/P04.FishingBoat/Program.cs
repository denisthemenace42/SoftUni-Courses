using System;

namespace P04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double groupSize = double.Parse(Console.ReadLine());
            double seasonPrice = 0.0;
            switch (season)
            {
                case "Summer":
                    seasonPrice = 4200.00;
                    if (groupSize % 2 == 0)
                    {
                        seasonPrice *= 0.95;
                    }
                    break;
                case "Autumn":
                    seasonPrice = 4200.00;
                    break;
                case"Winter":
                    seasonPrice = 2600.00;
                    if (groupSize % 2 == 0)
                    {
                        seasonPrice *= 0.95;
                    }
                    break;
                case "Spring":
                    seasonPrice = 3000.00;
                    if (groupSize % 2 == 0)
                    {
                        seasonPrice *= 0.95;
                    }
                    break;

            }
            if (groupSize <=6)
            {
                seasonPrice *= 0.90;
            }
            else if (groupSize > 7 && groupSize <= 11)
            {
                seasonPrice *= 0.85;
            }
            else if (groupSize > 11)
            {
                seasonPrice *= 0.75;
            }
            double leftSum = budget - seasonPrice;
            double requiredSum = seasonPrice - budget;
            if (budget >= seasonPrice)
            {
                Console.WriteLine($"Yes! You have {leftSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {requiredSum:f2} leva.");
            }
        }
    }
}
