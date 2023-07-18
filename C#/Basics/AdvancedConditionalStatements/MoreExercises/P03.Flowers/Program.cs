using System;
using System.Data;

namespace P03.Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());
            double chrysanthemumPrice = 0.0;
            double rosePrice = 0.0;
            double tulipsPrice = 0.0;
            double totalPrice = 0.0;
            int flowerCount = chrysanthemums + rose + tulips;
           
                switch (season)
            {
                case "Spring":
                case "Summer":
                    chrysanthemumPrice = 2.00;
                    rosePrice = 4.10;
                    tulipsPrice = 2.50;
                    break;
                case "Winter":
                case "Autumn":
                    chrysanthemumPrice = 3.75   ;
                    rosePrice = 4.50;
                    tulipsPrice = 4.15;
                    break;
            }
            totalPrice =(chrysanthemumPrice*chrysanthemums)+(rosePrice*rose)+(tulips*tulipsPrice);
            if (holiday ==  'Y') 
            {
                totalPrice *= 1.15;
            }
            if (season == "Spring" && tulips > 7)
            {
                totalPrice *= 0.95;
            }
            if (season == "Winter" && rose >= 10)
            {
                totalPrice *= 0.90;
            }

            if (flowerCount > 20)
            {
                totalPrice *= 0.80;
            }
            Console.WriteLine($"{totalPrice+2.00:f2}");

        }
    }
}
