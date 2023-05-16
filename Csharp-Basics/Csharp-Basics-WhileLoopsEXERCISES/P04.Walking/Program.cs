using System;

namespace P04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int stepSum = 0;
            while (stepSum < 10000)
            {
                input = Console.ReadLine();
                if (input == "Going home")
                {
                    stepSum += int.Parse(Console.ReadLine());
                    if (stepSum >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{stepSum - 10000} steps over the goal!");
                        
                        return;
                    }
                    else if (stepSum < 10000)
                    {
                        Console.WriteLine($"{10000 - stepSum} more steps to reach goal.");
                        return;
                    }
                }
                else
                {
                    stepSum += int.Parse(input);
                }
            }
            Console.WriteLine($"Goal reached! Good job!");
            Console.WriteLine($"{stepSum - 10000} steps over the goal!");
        }
    }
}
