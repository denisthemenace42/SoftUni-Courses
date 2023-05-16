using System;

namespace P01.TradeComissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double amountSells = double.Parse(Console.ReadLine());
            double endSum = 0.00;

            switch (city)
            {
                case "Plovdiv":
                    if (amountSells >= 0 && amountSells <= 500)
                    {
                        endSum = amountSells * 1.055 - amountSells;
                        Console.WriteLine($"{endSum:F2}");
                    }
                    else if (amountSells > 500 &&  amountSells <= 1000)
                    {
                        endSum = amountSells * 1.08 - amountSells;
                        Console.WriteLine($"{endSum:F2}");
                    }
                    else if (amountSells > 1000 && amountSells <= 10000)
                    {
                        endSum = amountSells * 1.12 - amountSells;
                        Console.WriteLine($"{endSum:F2}");
                    }
                    else if (amountSells > 10000)
                    {
                        endSum = amountSells * 1.145 - amountSells;
                        Console.WriteLine($"{endSum:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (amountSells >= 0 && amountSells <= 500)
                    {
                        endSum = amountSells * 1.045 - amountSells;
                        Console.WriteLine($"{endSum:F2}");
                    }
                    else if (amountSells > 500 && amountSells <= 1000)
                    {
                        endSum = amountSells * 1.075 - amountSells;
                        Console.WriteLine($"{endSum:F2}");
                    }
                    else if (amountSells > 1000 && amountSells <= 10000)
                    {
                        endSum = amountSells * 1.10 - amountSells;
                        Console.WriteLine($"{endSum:F2}");
                    }
                    else if (amountSells > 10000)
                    {
                        endSum = amountSells * 1.13 - amountSells;
                        Console.WriteLine($"{endSum:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Sofia":
                    if (amountSells >= 0 && amountSells <= 500)
                    {
                        endSum = amountSells * 1.05 - amountSells;
                        Console.WriteLine($"{endSum:F2}");
                    }
                    else if (amountSells > 500 && amountSells <= 1000)
                    {
                        endSum = amountSells * 1.07 - amountSells;
                        Console.WriteLine($"{endSum:F2}");
                    }
                    else if (amountSells > 1000 && amountSells <= 10000)
                    {
                        endSum = amountSells * 1.08 - amountSells;
                        Console.WriteLine($"{endSum:F2}");
                    }
                    else if (amountSells > 10000)
                    {
                        endSum = amountSells * 1.12 - amountSells;
                        Console.WriteLine($"{endSum:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
