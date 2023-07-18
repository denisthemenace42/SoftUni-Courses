using System;

namespace P04.CarToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double carPrice = 0.0;
            string carName = "";
            string carType = "";

            if (budget > 500)
            {
                carPrice = budget * 0.90;
                carName = "Luxury class";
                carType = "Jeep";

            }
            switch (season)
            {
                case "Summer":
                    if(budget > 100 && budget <= 500)
                    {
                        carPrice = budget * 0.45;
                        carName = "Compact class";
                        carType = "Cabrio";
                    }
                    else if (budget <= 100 )
                    {
                        carPrice = budget * 0.35;
                        carName = "Economy class";
                        carType = "Cabrio";
                    }
                    break;
                case "Winter":
                    if (budget > 100 && budget <= 500)
                    {
                        carPrice = budget * 0.80;
                        carName = "Compact class";
                        carType = "Jeep";
                    }
                    else if (budget <= 100)
                    {
                        carPrice = budget * 0.65;
                        carName = "Economy class";
                        carType = "Jeep";
                    }
                    break;
            }
            Console.WriteLine($"{carName}");
            Console.WriteLine($"{carType} - {carPrice:f2}");
        }
    }
}
