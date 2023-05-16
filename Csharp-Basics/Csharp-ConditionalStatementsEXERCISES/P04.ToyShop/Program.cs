using System;
using System.Diagnostics.CodeAnalysis;

namespace P04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceVac = double.Parse(Console.ReadLine());
            int puzzleN = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double totalMoney = 2.60 * puzzleN
            + dolls * 3.00
            + 4.10 * bears
            + 8.20 * minions
            + 2 * trucks;
            
            int totalNumbers = (puzzleN+dolls+bears+minions+trucks);
            if(totalNumbers >= 50)
            {
                totalMoney-= totalMoney * 0.25;
                
            }
            
                totalMoney -= totalMoney * 0.10;
            
            if (totalMoney >= priceVac)
            {
                
                Console.WriteLine($"Yes! {Math.Abs(totalMoney - priceVac):f2} lv left.");
            }
            else
            {
                    
                Console.WriteLine($"Not enough money! {Math.Abs(priceVac - totalMoney):f2} lv needed.");
            }
        }
    }
}
