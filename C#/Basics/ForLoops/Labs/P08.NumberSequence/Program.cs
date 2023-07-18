using System;

namespace P08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            for(int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers > maxNumber)
                {
                    maxNumber = numbers;
                }
                if (numbers < minNumber)
                {
                    minNumber = numbers;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        } 
    }
}
