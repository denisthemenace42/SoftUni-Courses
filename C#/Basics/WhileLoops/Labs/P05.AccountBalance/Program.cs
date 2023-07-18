using System;

namespace P05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0;
            while (input != "NoMoreMoney")
            {
                double deposit = double.Parse(input);
               input = Console.ReadLine();
                if (deposit < 0) 
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += deposit;
                Console.WriteLine($"Increase: {deposit:f2}");
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
