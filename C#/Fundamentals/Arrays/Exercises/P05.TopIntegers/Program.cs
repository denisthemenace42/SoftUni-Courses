using System;
using System.Linq;

namespace P05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            for(int i = 0; i < numbersArray.Length; i++)
            {
                bool isBiggest = true;
                for (int j = i + 1; j < numbersArray.Length; j++)
                {
                    if (numbersArray[i] <= numbersArray[j])
                    {
                        isBiggest = false;
                    }
                }
                if (isBiggest)
                {
                    Console.Write(numbersArray[i] + " ");
                }
            }
        }
    }
}
