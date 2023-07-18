using System;

namespace P04.InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double realNumber = double.Parse(Console.ReadLine());
            double inches = 2.54;
            double convert = realNumber * inches;
            Console.WriteLine(convert);
        }
    }
}
