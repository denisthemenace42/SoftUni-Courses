﻿using System;

namespace P06.TruckDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());
            double pricePerKM = 0;
            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if(kmPerMonth <= 5000)
                    {
                        pricePerKM = 0.75;
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        pricePerKM = 0.95;
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        pricePerKM = 1.45;
                    }
                    break;
                case "Summer":
                    if (kmPerMonth <= 5000)
                    {
                        pricePerKM = 0.90;
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        pricePerKM = 1.10;
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        pricePerKM = 1.45;
                    }
                    break;
                case "Winter":
                    if (kmPerMonth <= 5000)
                    {
                        pricePerKM = 1.05;
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        pricePerKM = 1.25;
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        pricePerKM = 1.45;
                    }
                    break;
            }
            double totalPrice = (pricePerKM*kmPerMonth)*4;
            totalPrice *= 0.90;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
