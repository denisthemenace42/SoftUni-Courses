using System;

class FuelTankPart2
{
    static void Main()
    {
        string fuelType = Console.ReadLine();
        double fuelRequired = double.Parse(Console.ReadLine());
        string discountCard = Console.ReadLine();

        double fuelPrice = 0;

        switch (fuelType)
        {
            case "Gasoline":
                fuelPrice = 2.22;
                if (discountCard == "Yes")
                {
                    fuelPrice -= 0.18;
                }
                break;
            case "Diesel":
                fuelPrice = 2.33;
                if (discountCard == "Yes")
                {
                    fuelPrice -= 0.12;
                }
                break;
            case "Gas":
                fuelPrice = 0.93;
                if (discountCard == "Yes")
                {
                    fuelPrice -= 0.08;
                }
                break;
        }

        double totalPrice = fuelPrice * fuelRequired;

        if (fuelRequired >= 20 && fuelRequired <= 25)
        {
            totalPrice *= 0.92;
        }
        else if (fuelRequired > 25)
        {
            totalPrice *= 0.9;
        }

        Console.WriteLine($"{totalPrice:F2} lv.");
    }
}
