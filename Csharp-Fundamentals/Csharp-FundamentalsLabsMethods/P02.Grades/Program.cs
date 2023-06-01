using System;

namespace P02.Grades
{
    internal class Program
    {
        static void printGrade(double number)
        {
            if (number <= 2.99)
            {
                Console.WriteLine($"Fail");
            }
            else if (number >= 3.00 && number <= 3.49)
            {
                Console.WriteLine($"Poor");
            }
            else if (number>= 3.50 && number<=4.49)
            {
                Console.WriteLine($"Good");
            }
            else if (number >= 4.50 && number <= 5.49)
            {
                Console.WriteLine($"Very good");
            }
            else
            {
                Console.WriteLine($"Excellent");
            }
        }
        static void Main(string[] args)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            printGrade(inputNumber);

        }
    }
}
