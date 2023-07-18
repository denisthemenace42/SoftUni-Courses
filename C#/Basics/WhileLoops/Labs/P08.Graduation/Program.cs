using System;

namespace P08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double finalScore = 0;
            int repeats = 0;
            int grade = 1;
            while (grade <= 12)
            {
                
                double score = double.Parse(Console.ReadLine());
                if (score < 4)
                {
                    repeats++;
                    
                    if (repeats > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        return;
                    }
                    continue;
                }
                finalScore += score;
                
                grade++;
            }
            finalScore = finalScore / 12;
            Console.WriteLine($"{name} graduated. Average grade: {finalScore:f2}");
        }
    }
}
