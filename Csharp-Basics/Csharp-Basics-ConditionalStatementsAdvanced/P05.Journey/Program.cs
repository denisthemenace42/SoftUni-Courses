using System;

namespace P05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = string.Empty;
            string locationType = string.Empty;
            double price = 0.0;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        locationType = "Camp";
                        price = budget* 0.30;
                        break;
                    case "winter":
                        locationType = "Hotel";
                        price = budget * 0.70;
                        break;
                }

            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        locationType = "Camp";
                        price = budget * 0.40;
                        break;
                    case "winter":
                        locationType = "Hotel";
                        price = budget * 0.80;
                        break;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                switch (season)
                {
                    case "summer":
                    case "winter":
                        locationType = "Hotel";
                        price = budget * 0.90;
                        break;
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{locationType} - {price:f2}");
        }
    }
}
