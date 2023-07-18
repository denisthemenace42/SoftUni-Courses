using System;

namespace P08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());
            double basketballShoes = yearTax - yearTax * 0.4;
            double basketballClothes = basketballShoes - basketballShoes * 0.2;
            double basketBall = basketballClothes / 4;
            double basketballAccessories = basketBall / 5;

            double totalPrice = basketballShoes + basketballClothes + basketballAccessories + basketBall + yearTax;

            Console.WriteLine(totalPrice);
        }
    }
}
