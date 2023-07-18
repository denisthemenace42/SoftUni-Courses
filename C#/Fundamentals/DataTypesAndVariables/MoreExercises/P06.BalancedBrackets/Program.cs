using System;

namespace P06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < numberLines; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    count++;
                }
                if (input == ")")
                {
                    count--;
                }
                if (count < 0)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
