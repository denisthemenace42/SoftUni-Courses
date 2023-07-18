using System;

namespace P02.BeerandChips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            double beerCount = double.Parse(Console.ReadLine())*1.20;
            double chipsCount = double.Parse(Console.ReadLine());
            double chips = Math.Ceiling((beerCount * 0.45)*chipsCount);
            double final = chips + beerCount;
            if (budget >= final)
            {
                Console.WriteLine($"{name} bought a snack and has {budget-final:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {final-budget:f2} more leva!");
            }

        }
    }
}
