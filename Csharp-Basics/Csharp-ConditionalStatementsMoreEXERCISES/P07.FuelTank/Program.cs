using System;

namespace P07.FuelTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelLiters = double.Parse(Console.ReadLine());
            if (fuelType == "Diesel" && fuelLiters >= 25)
            {
                Console.WriteLine($"You have enough diesel.");
            }
            else if (fuelType == "Diesel" && fuelLiters < 25)
            {
                Console.WriteLine($"Fill your tank with diesel!");
            }
            else if (fuelType == "Gasoline" && fuelLiters >= 25)
            {
                Console.WriteLine($"You have enough gasoline.");
            }
            else if (fuelType == "Gasoline" && fuelLiters < 25)
            {
                Console.WriteLine($"Fill your tank with gasoline!");
            }
            else if (fuelType == "Gas" && fuelLiters >= 25)
            {
                Console.WriteLine($"You have enough gas.");
            }
            else if (fuelType == "Gas" && fuelLiters < 25)
            {
                Console.WriteLine($"Fill your tank with gas!");
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
