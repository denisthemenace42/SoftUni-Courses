using Microsoft.VisualBasic;
using System;

namespace P05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = "";
            string housingType = "";
            switch (season)
            {
                case "Summer":
                    if (budget <= 1000)
                    {
                        housingType = "Camp";
                        location = "Alaska";
                        budget *= 0.65;
                    }
                    else if (budget >1000 && budget <= 3000)
                    {
                        housingType = "Hut";
                        location = "Alaska";
                        budget *= 0.80;
                    }
                    else if (budget > 3000)
                    {
                        housingType = "Hotel";
                        location = "Alaska";
                        budget *= 0.90;
                    }
                    break;
                case "Winter":
                    if (budget <= 1000)
                    {
                        housingType = "Camp";
                        location = "Morocco";
                        budget *= 0.45;
                    }
                    else if (budget > 1000 && budget <= 3000)
                    {
                        housingType = "Hut";
                        location = "Morocco";
                        budget *= 0.60;
                    }
                    else if (budget > 3000)
                    {
                        housingType = "Hotel";
                        location = "Morocco";
                        budget *= 0.90;
                    }
                    break;
            }
            Console.WriteLine($"{location} - {housingType} - {budget:f2}");
        }
    }
}
