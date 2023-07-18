using System;

namespace P04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lilyAge = int.Parse(Console.ReadLine());
            double priceWashermachine = double.Parse(Console.ReadLine());
            int priceToys = int.Parse(Console.ReadLine());
            int birthdayMoney = 0;

            for (int i = 1; i <= lilyAge; i++) 
            { 
                if (i % 2 == 0)
                {
                    birthdayMoney = birthdayMoney + i * 5 - 1;
                }
                else
                {
                    birthdayMoney = birthdayMoney + priceToys;
                }
            }
            
            if ( birthdayMoney >= priceWashermachine )
            {
                Console.WriteLine($"Yes! {birthdayMoney-priceWashermachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWashermachine - birthdayMoney:f2}");
            }
        }
    }
}
