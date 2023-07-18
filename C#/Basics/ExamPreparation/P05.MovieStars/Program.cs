using System;

namespace P05.MovieStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double budget = double.Parse(Console.ReadLine());
            double actorSum = 0;
            while (budget >0)
            {
                string name = Console.ReadLine(); 
                if(name == "ACTION")
                {
                    break;
                }
                if (name.Length <= 15)
                {
                    actorSum = double.Parse(Console.ReadLine());
                    budget -= actorSum;
                }
                if (name.Length > 15)
                {
                    actorSum = budget * 0.20;
                    budget -= actorSum;
                }
            }
            if (budget < 0)
            {
                Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
            }
            else
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
        }
    }
}
