using System;

namespace P07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNum = int.MaxValue;
            while (input != "Stop")
            {
                int newNum = int.Parse(input);
                input = Console.ReadLine();
                if (newNum < minNum)
                {
                    minNum = newNum;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
