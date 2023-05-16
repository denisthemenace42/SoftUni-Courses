using System;

namespace P02.BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string typeField = Console.ReadLine();
            double money = 0;
            switch (typeField)
            {
                case "trail":
                    money = juniors * 5.50
                           + seniors * 7;
                   break;

                case "cross-country":
                   money = juniors * 8
                        + seniors * 9.50;
                    if (juniors + seniors >= 50)
                    {
                        money -= money * 0.25;
                    }
                        break;
                case "downhill":
                    money = juniors * 12.25
                        + seniors * 13.75;
                    break;
                case "road":
                    money = juniors * 20
                        + seniors * 21.50;
                    break;
            }
            money *= 0.95;
            Console.WriteLine($"{money:f2}");

        }
    }
}
