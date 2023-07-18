using System;

namespace P07.OscarsCeremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rent = int.Parse(Console.ReadLine());
            double statue = rent * 0.70;
            double ket = statue * 0.85;
            double sound = ket / 2;
            double endSum = rent+statue+sound+ket;
            Console.WriteLine($"{endSum:f2}");
        }
    }
}
