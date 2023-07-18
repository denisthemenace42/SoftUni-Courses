using System;
using System.Linq;

namespace P04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = numberArray.Length / 4;
            int[] newNumberArray = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                newNumberArray[i] = numberArray[k - (i + 1)] + numberArray[k+i];
                newNumberArray[newNumberArray.Length - 1 - i] = numberArray[newNumberArray.Length - 1 - i + k] + numberArray[(newNumberArray.Length - 1 - i)+(k+2*i+1)];
            }
            Console.WriteLine(string.Join(" ",newNumberArray));
        }
    }
}
