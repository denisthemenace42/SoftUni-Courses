using System;

namespace P07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

            double chickenPrice = chickenMenu * 10.35;
            double fishPrice = fishMenu * 12.40;
            double veganPrice = veganMenu * 8.15;

            double desertPrice = (chickenPrice + fishPrice + veganPrice) * 0.2;
            double totalPrice = chickenPrice + fishPrice + veganPrice + desertPrice + 2.50;

            Console.WriteLine(totalPrice);

        }
    }
}
