namespace P07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double sum = 0;
            while ((input = Console.ReadLine()) != "Start")
            {
                double price = double.Parse(input);
                if (price != 1 && price != 2 && price != 0.1 && price != 0.2 && price != 0.5)
                {
                    Console.WriteLine($"Cannot accept {price}");
                }
                else
                {
                    sum += price;
                }
            }
            while ((input = Console.ReadLine()) != "End")
            {
                switch (input)
                {
                    case "Nuts":
                        sum -= 2.0;
                        if (sum < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sum += 2.0;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased nuts");
                        }
                    break;
                    case "Water":
                        sum -= 0.7;
                        if (sum<0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sum += 0.7;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased water");
                        }
                        break;
                    case "Coke":
                        sum -= 1.0;
                        if (sum < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sum += 1.0;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased coke");
                        }
                        break;
                    case "Soda":
                        sum -= 0.8;
                        if (sum < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sum += 0.8;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased soda");
                        }
                        break;
                    case "Crisps":
                        sum -= 1.5;
                        if (sum < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sum += 1.5;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased crisps");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}