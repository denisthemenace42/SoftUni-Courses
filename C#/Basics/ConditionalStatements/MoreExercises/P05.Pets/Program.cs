using System;

namespace P05.Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dayCount = double.Parse(Console.ReadLine());
            double leftFoodKG = double.Parse(Console.ReadLine());
            double foodPerDayDogsKG = double.Parse(Console.ReadLine());
            double foodPerDayCatsKG = double.Parse(Console.ReadLine());
            double foodPerDayTurtleGrams = double.Parse(Console.ReadLine());

            double dogFood = dayCount * foodPerDayDogsKG;
            double catFood = dayCount * foodPerDayCatsKG;
            double turtleFood = (dayCount * foodPerDayTurtleGrams) / 1000;
            double totalFood = dogFood + catFood + turtleFood;
            double foodLeftover = Math.Abs(totalFood - leftFoodKG);
            if (totalFood <= leftFoodKG)
            {
                Console.WriteLine($"{Math.Floor(foodLeftover)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodLeftover)} more kilos of food are needed.");
            }

        }
    }
}
