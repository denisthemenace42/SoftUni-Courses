using System;

namespace P03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            bool isEqual = Math.Abs(numberOne - numberTwo) < 0.000001;
            Console.WriteLine(isEqual);

        }
    }
}
