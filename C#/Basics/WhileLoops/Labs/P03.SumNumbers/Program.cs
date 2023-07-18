using System;

namespace P03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxSum = 0;
            while (number > maxSum)
            {
                int newNum = int.Parse(Console.ReadLine());
                maxSum += newNum;
            }
            Console.WriteLine(maxSum);
        }
    }
}
