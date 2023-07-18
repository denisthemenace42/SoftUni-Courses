using System;

namespace P04.TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());
            string typeDay = Console.ReadLine();
            if (typeDay == "day" && kilometers < 20)
            {
                double taxi = (kilometers * 0.79) + 0.70;
                Console.WriteLine("{0:f2}", taxi);
            }
            else if (typeDay == "night" && kilometers < 20)
            {
                double taxi = (kilometers * 0.90) + 0.70;
                Console.WriteLine("{0:f2}", taxi);
            }
            else if (kilometers >= 100)
            {
                double train = kilometers * 0.06;
                Console.WriteLine("{0:f2}", train);
            }
            else if (kilometers >= 20)
            {
                double bus = kilometers * 0.09;
                Console.WriteLine("{0:f2}", bus);
            }
        }
    }
}
