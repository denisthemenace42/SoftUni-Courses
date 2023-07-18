using System;

namespace P03.CoffeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string sugar = Console.ReadLine();
            int drinkCount = int.Parse(Console.ReadLine());
          
            double drink = 0;
            switch (type)
            {
                case "Espresso":
                    if (sugar == "Normal")
                    {
                        drink = 1;
                        if (drinkCount >= 5)
                        {
                            drink = 0.75;
                        }
                    }
                    else if (sugar == "Without")
                    {
                        drink = 0.90 * 0.65;
                        if (drinkCount >= 5)
                        {
                            drink *= 0.75;
                        }
                    }
                    else if (sugar == "Extra")
                    {
                        drink = 1.20;
                        if (drinkCount >= 5)
                        {
                            drink *= 0.75;
                        }
                    }
                    break;
                case "Cappuccino":
                    if (sugar == "Normal")
                    {
                        drink = 1.20;
                        
                    }
                    else if (sugar == "Without")
                    {
                        drink = 1 * 0.65;
                       
                    }
                    else if (sugar == "Extra")
                    {
                        drink = 1.60;
                    }
                    break;
                case "Tea":
                    if (sugar == "Normal")
                    {
                        drink = 0.60;

                    }
                    else if (sugar == "Without")
                    {
                        drink = 0.50 * 0.65;
                        
                    }
                    else if (sugar == "Extra")
                    {
                        drink = 0.70;
                    }
                    break;

            }
            double endSum = drink * drinkCount;
            if (endSum > 15)
            {
                endSum *= 0.80;
            }
            Console.WriteLine($"You bought {drinkCount} cups of {type} for {endSum:f2} lv.");
        }
    }
}
