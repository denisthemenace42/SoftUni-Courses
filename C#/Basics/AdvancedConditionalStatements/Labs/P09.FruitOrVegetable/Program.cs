using System;

namespace P09.FruitOrVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string foodType = Console.ReadLine();

            if (foodType == "banana" || foodType == "apple" || foodType == "cherry" || foodType == "kiwi" || foodType == "lemon" || foodType == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (foodType == "tomato" || foodType == "cucumber" || foodType == "pepper" || foodType == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
