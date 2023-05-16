using System;

namespace P03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers;
            int prime = 0;
            int nonPrime = 0;
            while ((numbers = Console.ReadLine()) != "stop") 
            { 
                int currNum = int.Parse(numbers);
                int primeCounter = 0;
                if (currNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                if (currNum == 0)
                {
                    continue;
                }
                for (int i = 1; i <= currNum; i++)
                {
                    if (currNum % i == 0)
                    {
                        primeCounter++;
                    }
                }
                if (primeCounter == 2) 
                {
                    prime += currNum;
                }
                else
                {
                    nonPrime += currNum;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrime}");
        }
    }
}
