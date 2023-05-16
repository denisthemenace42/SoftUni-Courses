using System;

namespace P11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double price = 0.0;

            if (dayOfTheWeek == "Sunday" || dayOfTheWeek == "Saturday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.70;
                        amount *= price;
                        Console.WriteLine($"{amount:f2}");
                        break;
                    case "apple":
                        price = 1.25;
                        amount *= price;
                        Console.WriteLine($"{amount:f2}");
                        break;
                    case "orange":
                        price = 0.90;
                        amount *= price;
                        Console.WriteLine($"{amount:f2}");
                        break;
                    case "grapefruit":
                        price = 1.60;
                        amount *= price;
                        Console.WriteLine($"{amount:f2}");
                        break;
                    case "kiwi":
                        price = 3.00;
                        amount *= price;
                        Console.WriteLine($"{amount:f2}");
                        break;
                    case "pineapple":
                        price = 5.60;
                        amount *= price;
                        Console.WriteLine($"{amount:f2}");
                        break;
                    case "grapes":
                        price = 4.20;
                        amount *= price;
                        Console.WriteLine($"{amount:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday"
                || dayOfTheWeek == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.50;
                        amount *= price;
                        Console.WriteLine($"{amount:f2}");
                        break;
                    case "apple":
                        price = 1.20;
                        amount *= price;
                        Console.WriteLine($"{amount:f2}");
                        break;
                    case "orange":
                        price = 0.85;
                        amount *= price;
                        Console.WriteLine($"{amount:f2}");
                        break;
                    case "grapefruit":
                        price = 1.45;
                        amount *= price;
                        Console.WriteLine($"{amount:f2}");
                        break;
                    case "kiwi":
                        price = 2.70;
                        amount *= price;
                        Console.WriteLine($"{amount:f2}");
                        break;
                    case "pineapple":
                        price = 5.50;
                        amount *= price;
                        Console.WriteLine($"{amount:f2}");
                        break;
                    case "grapes":
                        price = 3.85;
                        amount *= price;
                        Console.WriteLine($"{amount:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
