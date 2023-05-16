using System;

class FuelCalculator
{
    static void Main()
    {
        string fuelType = Console.ReadLine();
        double fuelAmount = double.Parse(Console.ReadLine());
        string hasClubCard = Console.ReadLine();

        double fuelPrice = 0;

        switch (fuelType)
        {
            case "Gasoline":
                fuelPrice = 2.22;
                if (hasClubCard == "Yes")
                {
                    fuelPrice -= 0.18;
                }
                break;
            case "Diesel":
                fuelPrice = 2.33;
                if (hasClubCard == "Yes")
                {
                    fuelPrice -= 0.12;
                }
                break;
            case "Gas":
                fuelPrice = 0.93;
                if (hasClubCard == "Yes")
                {
                    fuelPrice -= 0.08;
                }
                break;
        }

        double totalPrice = fuelPrice * fuelAmount;

        if (fuelAmount >= 20 && fuelAmount <= 25)
        {
            totalPrice *= 0.92; // 8% discount
        }
        else if (fuelAmount > 25)
        {
            totalPrice *= 0.9; // 10% discount
        }

        Console.WriteLine($"{totalPrice:F2} lv.");
    }
}
