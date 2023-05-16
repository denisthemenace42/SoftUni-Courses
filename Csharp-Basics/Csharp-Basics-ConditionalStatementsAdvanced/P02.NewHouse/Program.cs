using System;

namespace P02.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int amountFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double leftSum = 0.0;
            double sumRequired = 0.0;
            double priceFlowers = 0.0;

            switch (typeFlowers)
            {
                case "Roses":
                    priceFlowers = 5.00 *amountFlowers;
                    if (amountFlowers > 80) 
                    {
                        priceFlowers *= 0.90;
                    }
                    break;
                case "Dahlias":
                    priceFlowers = 3.80*amountFlowers;
                    if ( amountFlowers > 90)
                    {
                        priceFlowers *= 0.85;
                    }
                    break;
                case "Tulips":
                    priceFlowers = 2.80*amountFlowers;
                    if( amountFlowers > 80)
                    {
                        priceFlowers *= 0.85;
                    }
                    break;
                case "Narcissus":
                    priceFlowers = 3.00*amountFlowers;
                    if ( priceFlowers < 120)
                    {
                        priceFlowers *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    priceFlowers = 2.50*amountFlowers;
                    if (amountFlowers < 80)
                    {
                        priceFlowers *= 1.20;
                    }
                    break;
            }
            leftSum = budget - priceFlowers;
            sumRequired = priceFlowers - budget;
            if (budget >= priceFlowers)
            {
                Console.WriteLine($"Hey, you have a great garden with {amountFlowers} {typeFlowers} and {leftSum:f2} leva left."); //Ако бюджета им е достатъчен - 

            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sumRequired:f2} leva more."); //Ако бюджета им е НЕ достатъчен -
            }
        }
    }
}
