using System;

namespace P08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFoodN = int.Parse(Console.ReadLine());
            int catFoodN = int.Parse(Console.ReadLine());

            double dogFood = 2.50;
            int catFood = 4;

            double sum = (dogFoodN * dogFood) + (catFoodN * catFood);
           
            Console.WriteLine($"{sum} lv.");
            
        }
    }
}
