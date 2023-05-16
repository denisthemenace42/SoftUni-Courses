using System;
using System.Security;

namespace P02.EqualSumsEvenOddPositions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            for (int n1 = number1; n1 <= number2; n1++)
            {
                string currentNum = n1.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int n2 = 0; n2 <currentNum.Length; n2++)
                {
                    int currentDigit = int.Parse(currentNum[n2].ToString());
                    if (n2 % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
                if (oddSum == evenSum) 
                {
                    Console.Write(n1 + " ");
                }
            }
        }
    }
}
