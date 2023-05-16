using System;

namespace P09.SkiResort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nightCounts = int.Parse(Console.ReadLine())-1;
            string roomType = Console.ReadLine();
            string review = Console.ReadLine();
            double roomPrice = 0.0;
            double endPrice = 0.0;

            switch (roomType)
            {
                case "room for one person":
                    roomPrice = 18.00;
                    endPrice = roomPrice * nightCounts;
                    break;
                case "apartment":
                    roomPrice = 25.00;
                    if(nightCounts < 10)
                    {
                        endPrice = roomPrice * nightCounts;
                        endPrice *= 0.70;
                    }
                    else if (nightCounts >= 10 && nightCounts <= 15)
                    {
                        endPrice = roomPrice * nightCounts;
                        endPrice *= 0.65;
                    }
                    else
                    {
                        endPrice = roomPrice * nightCounts;
                        endPrice *= 0.50;
                    }
                    break;
                case "president apartment":
                    roomPrice = 35.00;
                    if (nightCounts < 10)
                    {
                        endPrice = roomPrice * nightCounts;
                        endPrice *= 0.90;
                    }
                    else if (nightCounts >= 10 && nightCounts <= 15)
                    {
                        endPrice = roomPrice * nightCounts;
                        endPrice *= 0.85;
                    }
                    else
                    {
                        endPrice = roomPrice * nightCounts;
                        endPrice *= 0.80;
                    }
                    break;
            }
            if (review == "positive")
            {
                endPrice *= 1.25;
            }
            else if (review == "negative")
            {
                endPrice *= 0.90;
            }
            Console.WriteLine($"{endPrice:F2}");
        }
    }
}
