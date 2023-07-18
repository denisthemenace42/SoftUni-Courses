using System;

namespace P06.FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnolia = int.Parse(Console.ReadLine());
            int hyacinth = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double gift = double.Parse(Console.ReadLine());

            double totalSum = (magnolia * 3.25) + (hyacinth * 4.00) + (rose * 3.50) + (cactus * 8.00);
            double realSum = totalSum - totalSum * 0.05;
            double difference = Math.Abs(realSum - gift);
           
            if ( realSum >= gift )
            {
                Console.WriteLine($"She is left with {Math.Floor(difference)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(difference)} leva.");
            }
        }
    }
}
