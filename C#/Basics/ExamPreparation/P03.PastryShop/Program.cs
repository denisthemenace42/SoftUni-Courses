using System;

namespace P03.PastryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            double price = 0;

            switch (type)
            {
                case "Cake":
                    if (day > 15)
                    {
                        price = 28.70 * count;
                    }
                    else
                    {
                        price = 24* count;
                    }
                    break;
                case "Souffle":
                    if (day > 15)
                    {
                        price = 9.80 * count;
                    }
                    else
                    {
                        price = 6.66 * count;
                    }
                    break;
                case "Baklava":
                    if (day > 15)
                    {
                        price = 16.98 * count;
                    }
                    else
                    {
                        price = 12.60 * count;
                    }
                    break;
            }
            if (day <= 22)
            {
                if (price > 100 && price <= 200)
                {
                    price *= 0.85;
                }
                else if (price > 200)
                {
                    price *= 0.75;
                }
                if (day <= 15)
                {
                    price *= 0.90;
                }
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
