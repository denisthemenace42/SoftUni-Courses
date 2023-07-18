using System;

namespace P07.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int endSum = 0;
            for (int i = 0; i < count; i+=1)
            {
                int numbers = int.Parse(Console.ReadLine());
                endSum += numbers;
            }
            Console.WriteLine(endSum);
        }
    }
}
