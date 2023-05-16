using System;

namespace P02.HalfSumElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int endSum = 0;
            int max = int.MinValue;
            for(int i = 0; i < n; i++) 
            {
                int numbers = int.Parse(Console.ReadLine());

                endSum += numbers;

                if(numbers > max)
                {
                    max = numbers;
                }
            }
            int sumWithoutMaxNumber = endSum - max;

            if (max == sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(max - sumWithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
