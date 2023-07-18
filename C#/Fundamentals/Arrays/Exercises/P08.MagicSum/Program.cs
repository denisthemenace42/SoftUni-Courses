using System;
using System.Linq;

namespace P08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersArray.Length-1; i++)
            {
                for(int j = i +1; j < numbersArray.Length; j++)
                {
                    if (numbersArray[i] + numbersArray[j] == number)
                    {
                        Console.Write(numbersArray[i] + " " + numbersArray[j]);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
