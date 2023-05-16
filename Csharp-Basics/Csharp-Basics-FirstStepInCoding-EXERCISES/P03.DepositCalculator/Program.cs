using System;

namespace P03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double interestStack = deposit * (interest / 100);
            double monthInterest = interestStack / 12;
            double sum = deposit + months * monthInterest;
            Console.WriteLine(sum);
        }
    }
}
