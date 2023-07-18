using System;

namespace P04.VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceVegies = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            int amountVegies = int.Parse(Console.ReadLine());
            int amountFruits = int.Parse(Console.ReadLine());
          
            double total = (priceVegies * amountVegies) + (priceFruits* amountFruits);
            double euro = total / 1.94;
            Console.WriteLine("{0:F2}", euro);
        }
    }
}
