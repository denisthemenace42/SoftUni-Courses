namespace P03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float currentBalance = float.Parse(Console.ReadLine());
            string input = string.Empty;
            float currentSpent = 0;
            while ((input = Console.ReadLine()) != "Game Time")
            {
                switch (input)
                {
                    case "RoverWatch":
                        if (currentBalance < 29.98)
                        {

                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            currentBalance -= 29.99f;
                            currentSpent += 29.99f;
                            Console.WriteLine($"Bought {input}");

                            if (currentBalance <= 0)
                            {
                                Console.WriteLine("Out of money");
                                return;
                            }
                        }
                        continue;
                    case "Honored 2":
                        if (currentBalance < 59.98)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            currentBalance -= 59.99f;
                            currentSpent += 59.99f;
                            Console.WriteLine($"Bought {input}");
                            if (currentBalance <= 0)
                            {
                                Console.WriteLine("Out of money");
                                return;
                            }
                        }
                        continue;
                    case "Zplinter Zell":
                        if (currentBalance < 19.98)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            currentBalance -= 19.99f;
                            currentSpent += 19.99f;
                            Console.WriteLine($"Bought {input}");
                            if (currentBalance <= 0)
                            {
                                Console.WriteLine("Out of money");
                                return;
                            }
                        }
                        continue;
                    case "OutFall 4":
                        if (currentBalance < 39.98)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            currentBalance -= 39.99f;
                            currentSpent += 39.99f;
                            Console.WriteLine($"Bought {input}");
                            if (currentBalance <= 0)
                            {
                                Console.WriteLine("Out of money");
                                return;
                            }
                        }
                        continue;
                    case "RoverWatch Origins Edition":
                        if (currentBalance < 39.98)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            currentBalance -= 39.99f;
                            currentSpent += 39.99f;
                            Console.WriteLine($"Bought {input}");
                            if (currentBalance <= 0)
                            {
                                Console.WriteLine("Out of money");
                                return;
                            }
                        }
                        continue;
                    case "CS: OG":
                       if (currentBalance < 15.98)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            currentBalance -= 15.99f;
                            currentSpent += 15.99f;
                            Console.WriteLine($"Bought {input}");
                            if (currentBalance <= 0)
                            {
                                Console.WriteLine("Out of money");
                                return;
                            }
                        }
                        continue;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }
                
            }
            Console.WriteLine($"Total spent: ${currentSpent:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}