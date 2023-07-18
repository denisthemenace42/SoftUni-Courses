using System;

namespace P02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badScore = int.Parse(Console.ReadLine());
            int taskCounter = 0;
            int badScoreCounter = 0;
            double avgScore = 0;
            string lastProblem = "";
            bool isFailed = true;

            while (badScoreCounter < badScore)
            {
                string name = Console.ReadLine();
                if (name == "Enough")
                {
                    isFailed = false;
                    break;
                    
                }
                int score = int.Parse(Console.ReadLine());
                if (score <= 4)
                {
                    badScoreCounter++;
                }

                avgScore += score;
                lastProblem = name;
                taskCounter++;
            }
            avgScore = avgScore / taskCounter;
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {badScore} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {avgScore:f2}");
                Console.WriteLine($"Number of problems: {taskCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
