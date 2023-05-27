using System;
using System.Linq;

namespace P06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
   
            for(int i = 0; i < numbersArray.Length; i++)
            {
                int leftSum = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum+= numbersArray[j];
                }
                int rightSum = 0;
                for (int k = i + 1; k < numbersArray.Length; k++)
                {
                    rightSum+= numbersArray[k];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
