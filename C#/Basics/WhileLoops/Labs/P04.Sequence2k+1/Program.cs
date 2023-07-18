using System;

namespace P04.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int newNumber = 1;
            while (number >= newNumber)
            {
                Console.WriteLine(newNumber);
                newNumber = newNumber * 2 + 1;
            }
        }
    }
}
