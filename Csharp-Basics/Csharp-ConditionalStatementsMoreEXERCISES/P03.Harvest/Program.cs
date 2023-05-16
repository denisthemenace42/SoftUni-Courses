using System;

namespace P03.Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double squaresVineyard = double.Parse(Console.ReadLine());
            double vinePerSquare = double.Parse(Console.ReadLine());
            double requiredWine = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double totalVine = squaresVineyard * vinePerSquare;
            double wine = (totalVine * 0.40) / 2.5;
            double wineLeft = Math.Abs(wine - requiredWine);
            if (wine >= requiredWine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(wineLeft / workers)} liters per person.");
            }
            else {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineLeft)} liters wine needed.");
            }
         
        }
    }
}
