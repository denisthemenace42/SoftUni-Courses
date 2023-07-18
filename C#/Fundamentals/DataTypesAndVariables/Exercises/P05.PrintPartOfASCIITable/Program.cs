using System;

namespace P05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decNumber1 = int.Parse(Console.ReadLine());
            int decNumber2 = int.Parse(Console.ReadLine());
            for (int i = decNumber1; i<= decNumber2; i++)
            {
                char symbol = Convert.ToChar(i);
                Console.Write($"{symbol} ");
            }
        }
    }
}
