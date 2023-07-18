using System;

namespace P05.ChristmasGift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int kids = 0;
            int adults = 0;
            int sweaters = 15;
            int toys = 5;
            while((input = Console.ReadLine()) != "Christmas")
            {
                int age = int.Parse(input);
                if (age <= 16)
                {
                    kids++;
                }
                else if (age > 16)
                {
                    adults++;
                }
            }
            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {toys*kids}");
            Console.WriteLine($"Money for sweaters: {sweaters*adults}");
        }
    }
}
