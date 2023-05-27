using System;
using System.Linq;

namespace P03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            int[] firstArray = new int[inputLines];
            int[] secondArray = new int[inputLines];
            bool zigZag = false;
            for (int i = 0; i < inputLines; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (zigZag)
                {
                    firstArray[i] = numbers[1];
                    secondArray[i] = numbers[0];
                   
                }
                else
                {
                    firstArray[i] = numbers[0];
                    secondArray[i] = numbers[1];
                }
                zigZag = !zigZag;
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(' ', secondArray));
        }
    }
}
