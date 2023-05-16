using System;

namespace P01.DishWasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int detergentBottles = int.Parse(Console.ReadLine());
            int dishesCleaned = 0;
            int potsCleaned = 0;

            string input = Console.ReadLine();
            int counter = 1;
            detergentBottles *= 750;
            while (input != "End")
            {
                int dishesToWash = int.Parse(input);

                if (counter % 3 == 0)
                {
                    potsCleaned += dishesToWash;
                    detergentBottles -= dishesToWash * 15;
                }
                else
                {
                    dishesCleaned += dishesToWash;
                    detergentBottles -= dishesToWash * 5;
                }

                if (detergentBottles < 0)
                {
                    Console.WriteLine($"Not enough detergent, {-detergentBottles} ml. more necessary!");
                    return;
                }

                counter++;
                input = Console.ReadLine();
            }

            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{dishesCleaned} dishes and {potsCleaned} pots were washed.");
            Console.WriteLine($"Leftover detergent {detergentBottles} ml.");
        }
    }
}
