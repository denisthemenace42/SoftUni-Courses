using System;

namespace P11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            
            if (multiplier >10)
            {
                Console.WriteLine($"{number} X {multiplier} = {number*multiplier}");
            }
            else
            {
                while (multiplier <= 10)
                {
                    Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
                    multiplier++;
                }
            }
        }
    }
}
