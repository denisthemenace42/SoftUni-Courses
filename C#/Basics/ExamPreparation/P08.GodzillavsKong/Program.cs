using System;

namespace P08.GodzillavsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double statu = double.Parse(Console.ReadLine());
            double clothing = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            
            if (statu > 150)
            {
                clothing *= 0.90;
            }
            double endSum = (statu*clothing)+decor;
            if (endSum > budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {endSum-budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budget-endSum:f2} leva left.");
            }
        }
    }
}
