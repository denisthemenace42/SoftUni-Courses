using System;
using System.Xml;

namespace P09.NumbersFrom1To10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = 1;
            while (numbers <= 10)
            {
                Console.WriteLine(numbers++);
            }
        }
    }
}
