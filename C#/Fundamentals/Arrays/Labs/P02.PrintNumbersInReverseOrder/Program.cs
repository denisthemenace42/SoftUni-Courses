using System;

namespace P02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int[] number = new int[numberCount];
            for (int i = 0; i < numberCount; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            for (int k = numberCount - 1; k >= 0; k--)
            {
                Console.Write(number[k]+ " ");
            }
        }
    }
}
