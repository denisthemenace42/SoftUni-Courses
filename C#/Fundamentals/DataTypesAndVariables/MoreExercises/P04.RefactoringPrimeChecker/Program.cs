using System;

namespace P04.RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            string isPrimeLowerCase = string.Empty;
            for (int number = 2; number <= numberCount; number++)
            {
                bool isPrime = true;
                for (int factoriel = 2; factoriel < number; factoriel++)
                {
                    if (number % factoriel == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    isPrimeLowerCase = "true";
                } 
                else
                {
                    isPrimeLowerCase = "false";
                }
                Console.WriteLine($"{number} -> {isPrimeLowerCase}");
            }
        }
    }
}
