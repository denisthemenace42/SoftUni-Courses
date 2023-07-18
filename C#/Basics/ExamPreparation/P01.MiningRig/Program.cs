using System;

namespace P01.MiningRig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gpu = double.Parse(Console.ReadLine())*13;
            double transition = double.Parse(Console.ReadLine())*13;
            double pkWh = double.Parse(Console.ReadLine());
            double profit = double.Parse(Console.ReadLine())-pkWh;
            double endSum = gpu + transition + 1000;
            double perDay = 13 * profit;
            double final = Math.Ceiling(endSum / perDay);
            Console.WriteLine(endSum);
            Console.WriteLine(final);
        }
    }
}
