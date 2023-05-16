using System;

namespace P02.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());
            string dayType = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (temperature >= 10 && temperature <= 18)
            {

                if (dayType == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (dayType == "Afternoon" || dayType == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (temperature > 18 && temperature <= 24)
            {
                if (dayType == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (dayType == "Morning" || dayType == "Evening")
                {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                }
            }
            else if (temperature >= 25)
            {
                if (dayType == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (dayType == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (dayType == "Evening")
                {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
        }
    }
}

