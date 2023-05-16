using System;

namespace P07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceApartments = 0.0;
            double priceStudio = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    priceApartments = 65.00 *nights;
                    priceStudio = 50.00*nights;
                    if(nights > 14)
                    {
                        priceStudio *= 0.70;
                        priceApartments *= 0.90;
                    }
                    else if (nights > 7)
                    {
                        priceStudio *= 0.95;
                    }
                    break;
                case "June":
                case "September":
                    priceApartments = 68.70*nights;
                    priceStudio = 75.20*nights;
                    if (nights > 14)
                    {
                        priceStudio *= 0.80;
                        priceApartments *= 0.90;
                    }
                    break;
                case "July":
                case "August":
                    priceApartments = 77.00 * nights;
                    priceStudio = 76.00 * nights;
                    if (nights > 14)
                    {
                        priceApartments *= 0.90;
                    }
                    break;
            }

            Console.WriteLine($"Apartment: {priceApartments:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }
    }
}
