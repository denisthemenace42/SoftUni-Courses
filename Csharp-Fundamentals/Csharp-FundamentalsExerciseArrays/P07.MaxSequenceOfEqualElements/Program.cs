using System;
using System.Linq;

namespace P07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int repeatedNumber = 0;
            int repetitionCount = 0;
            int counter = 1;
            
            for (int i = 0; i < numbersArray.Length - 1; i++) 
            {
                if (numbersArray[i] == numbersArray[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > repetitionCount)
                {
                    repetitionCount = counter;
                    repeatedNumber = numbersArray[i];
                }
            }
            for (int j=1;j<=repetitionCount;j++)
            {
                Console.Write(repeatedNumber + " ");
            }
        }
    }
}
