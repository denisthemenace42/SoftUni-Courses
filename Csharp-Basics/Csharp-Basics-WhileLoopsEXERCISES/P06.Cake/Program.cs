using System;

namespace P06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int cakeSizeA = int.Parse(Console.ReadLine());
           int cakeSize = int.Parse(Console.ReadLine())*cakeSizeA;
            
            while(cakeSize > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                int pieces = int.Parse(input);
                cakeSize -= pieces;
            }
            if (cakeSize > 0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
            }
        }
    }
}
