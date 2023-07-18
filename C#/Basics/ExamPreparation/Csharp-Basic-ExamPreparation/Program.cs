using System;

namespace Csharp_Basic_ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int ticketCountAdult = int.Parse(Console.ReadLine());
            int ticketCountChild = int.Parse(Console.ReadLine());
            double ticketPriceNeto = double.Parse(Console.ReadLine());
            double taxPrice = double.Parse(Console.ReadLine());
            double endSum = 0;

            double ticketChild = (ticketPriceNeto * 0.30) + taxPrice;
            double ticketAdult = ticketPriceNeto + taxPrice;
            endSum = (ticketCountAdult* ticketAdult)+(ticketCountChild* ticketChild);

            Console.WriteLine($"The profit of your agency from {name} tickets is {(endSum*0.20):f2} lv.");
        }
    }
}
