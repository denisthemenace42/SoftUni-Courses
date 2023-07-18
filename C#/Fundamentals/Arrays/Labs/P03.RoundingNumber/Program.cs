using System;
using System.Linq;

namespace P03.RoundingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] roundedNumber = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNumber[i] = (int)Math.Round(numbers[i],MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < roundedNumber.Length; i++)
            {
                    Console.WriteLine($"{numbers[i]} => {roundedNumber[i]}");
            }
        }
    }
}
