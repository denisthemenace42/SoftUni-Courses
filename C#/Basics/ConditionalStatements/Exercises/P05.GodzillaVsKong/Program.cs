using System;

namespace P05.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double pricePerStatist = double.Parse(Console.ReadLine());
            double price = statist * pricePerStatist;
            double decor = budget * 0.10;              
            
            
            if (statist >= 150)
            {
                price -= price * 0.10;
            }
            price += decor; 
            if (budget >= price)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(budget-price):f2} leva left.");
            }
            else if(budget < price)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget-price):f2} leva more.");
            }
        }
    }
}
