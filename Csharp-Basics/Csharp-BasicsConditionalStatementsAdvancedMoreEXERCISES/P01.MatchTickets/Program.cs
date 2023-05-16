using System;

namespace P01.MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            double groupAmount = double.Parse(Console.ReadLine());
            double ticketsPrice = 0;
            double transportPrice = 0;

            if (groupAmount >= 50)
            {
                transportPrice = budget * 0.25;
            }
            else if (groupAmount  >= 25 && groupAmount <=49)
            {
                transportPrice = budget * 0.40;
            }
            else if (groupAmount >= 10 && groupAmount <= 24)
            {
                transportPrice = budget * 0.50;
            }
            else if (groupAmount >= 5 && groupAmount <= 9)
            {
                transportPrice = budget * 0.60;
            }
            else
            {
                transportPrice = budget * 0.75;
            }
            double totalPrice = Math.Abs(transportPrice-budget);
            switch (ticketType)
            {
                case "VIP":
                    ticketsPrice = groupAmount * 499.99;
                    break;

                case "Normal":
                    ticketsPrice = groupAmount * 249.99;
                    break;
            }
         
            if (ticketsPrice <= totalPrice)
            {
                double totalPrice2 = Math.Abs(totalPrice - ticketsPrice);
                Console.WriteLine($"Yes! You have {totalPrice2:f2} leva left.");
            }
            else
            {
                double totalPrice2 = Math.Abs(totalPrice - ticketsPrice);
                Console.WriteLine($"Not enough money! You need {totalPrice2:f2} leva.");
            }
        }
    }
}
