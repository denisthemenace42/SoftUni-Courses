using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCardsCount = int.Parse(Console.ReadLine());
            int processorsCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());

            double videoCardsPrice = videoCardsCount * 250.0;
            double processorsPrice = processorsCount * (videoCardsPrice * 0.35);
            double ramPrice = ramCount * (videoCardsPrice * 0.1);
            double totalPrice = videoCardsPrice + processorsPrice + ramPrice;

            if (videoCardsCount > processorsCount)
            {
                totalPrice *= 0.85; // apply 15% discount
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {budget - totalPrice:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva more!");
            }
        }
    }
}





