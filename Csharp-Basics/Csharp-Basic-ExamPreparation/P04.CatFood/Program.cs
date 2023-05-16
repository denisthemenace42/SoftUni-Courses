using System;

namespace P04.CatFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int catCount = int.Parse(Console.ReadLine());
            int gr1 = 0;
            int gr2 = 0;
            int gr3 = 0;
            double price = 0;
            for (int i = 0; i < catCount; i++)
            {
                double gramsFood = double.Parse(Console.ReadLine());
                price += gramsFood;
                if (gramsFood >= 100 && gramsFood < 200)
                {
                    gr1++;
                }
                else if (gramsFood >= 200 && gramsFood < 300)
                {
                    gr2++;
                }
                else if (gramsFood >= 300 && gramsFood < 400)
                {
                    gr3++;
                }
            }
            price /= 1000;
            price *= 12.45;
            Console.WriteLine($"Group 1: {gr1} cats.");
            Console.WriteLine($"Group 2: {gr2} cats.");
            Console.WriteLine($"Group 3: {gr3} cats.");
            Console.WriteLine($"Price for food per day: {price:f2} lv.");

        }
    }
}
