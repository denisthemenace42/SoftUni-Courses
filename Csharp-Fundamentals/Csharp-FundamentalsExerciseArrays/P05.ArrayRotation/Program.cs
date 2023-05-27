using System;
using System.Linq;

namespace P04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationCount = int.Parse(Console.ReadLine());
            var p = 1;
            while (p <= rotationCount)
            {
                var last = numbersArray[0];
                for (int i = 0; i < numbersArray.Length - 1; i++)
                {
                    numbersArray[i] = numbersArray[i + 1];
                }
                numbersArray[numbersArray.Length - 1] = last;
                p++;
            }
            for (int i = 0;i < numbersArray.Length; i++)
            {
                Console.Write(numbersArray[i] + " ");
            }
           
        }
    }
}
