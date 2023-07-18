using System;

namespace P08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tCount = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int wins = 0;
            int f = 0;
            int sf = 0;
            for (int i = 0; i < tCount; i++)
            {
                string type = Console.ReadLine();
                if (type == "F")
                {
                    startPoints += 1200;
                    f++;
                }
                else if (type == "SF")
                {
                    startPoints += 720;
                    sf++;
                }
                else if (type == "W")
                {
                    startPoints += 2000;
                    wins++;
                }
            }
            int avgPoints = ((f*1200)+(sf*720)+(wins*2000)) / tCount;
            double percentWins = ((double)wins / (double)tCount)*100;
            Console.WriteLine($"Final points: {startPoints}");
            Console.WriteLine($"Average points: {avgPoints}");
            Console.WriteLine($"{percentWins:f2}%");
        }
    }
}
