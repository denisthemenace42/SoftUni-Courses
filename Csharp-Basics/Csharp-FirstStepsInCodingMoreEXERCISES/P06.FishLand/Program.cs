using System;

namespace P06.FishLand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceMackerel = double.Parse(Console.ReadLine());
            double priceSprat = double.Parse(Console.ReadLine());
            double amountBonito = double.Parse(Console.ReadLine()); // 60% expensive than Mackerel
            double amountSafrid = double.Parse(Console.ReadLine()); // 80% expensive than Sprat
            int amountMussels = int.Parse(Console.ReadLine());
            double mussel = amountMussels * 7.50;
            double priceBonito = priceMackerel+priceMackerel * 0.60;
            double priceSafrid = priceSprat + priceSprat * 0.80;
            double total = (amountBonito*priceBonito)+(amountSafrid*priceSafrid)+mussel;
            Console.WriteLine("{0:F2}",total);   
        }
    }
}
