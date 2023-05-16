using System;

namespace P09.Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double square = double.Parse(Console.ReadLine());
            double squarePrice = 7.61 * square;
            double discount = 0.18 * squarePrice;

            double finalPrice = squarePrice - discount;

            Console.WriteLine("The final price is:" + "{0:F4}",finalPrice + " lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
