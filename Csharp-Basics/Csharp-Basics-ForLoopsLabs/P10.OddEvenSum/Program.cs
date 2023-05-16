using System;

namespace P10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddNum = 0;
            int evenNum = 0;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (i % 2 == 0) evenNum += numbers;
                else oddNum += numbers;
            }
            if (oddNum == evenNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenNum - oddNum)}");
            }
        }
    }
}
