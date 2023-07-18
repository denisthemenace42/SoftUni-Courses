using System;

namespace P01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void signOfIntegerNumber(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            signOfIntegerNumber(inputNumber);

        }
    }
}
