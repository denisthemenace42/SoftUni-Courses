using System;
using System.Diagnostics.Tracing;

namespace P02.ReportSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int expectedSum = int.Parse(Console.ReadLine());
            int cashTransactionsCount = 0;
            int cardTransactionsCount = 0;
            int totalCashAmount = 0;
            int totalCardAmount = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }

                int price = int.Parse(input);

                if (price >= 100)
                {
                    Console.WriteLine("Error in transaction!");
                    continue;
                }

               

            if (totalCashAmount + totalCardAmount >= expectedSum)
            {
                double averageCashPayment = 0;
                double averageCardPayment = 0;

                if (cashTransactionsCount > 0)
                {
                    averageCashPayment = (double)totalCashAmount / cashTransactionsCount;
                }

                if (cardTransactionsCount > 0)
                {
                    averageCardPayment = (double)totalCardAmount / cardTransactionsCount;
                }

                Console.WriteLine($"Average CS: {averageCashPayment:F2}");
                Console.WriteLine($"Average CC: {averageCardPayment:F2}");
            }
        }
    }
}
