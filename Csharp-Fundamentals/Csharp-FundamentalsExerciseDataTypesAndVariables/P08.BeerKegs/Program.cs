using System;

namespace P08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beerCount = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string modelName = string.Empty;
            string biggestBeer = string.Empty;

            for (int i = 0; i < beerCount; i++)
            {
                modelName = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume =  Math.PI * (radius*radius) *height;
                if (volume> biggestKeg)
                {
                    biggestKeg = volume;
                    biggestBeer = modelName;
                }
            }
            Console.WriteLine(biggestBeer);
        }
    }
}
