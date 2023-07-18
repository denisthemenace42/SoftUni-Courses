using System;

namespace P01.PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int capacityPool = int.Parse(Console.ReadLine());
           double P1 = double.Parse(Console.ReadLine());
           double P2 = double.Parse(Console.ReadLine());
           double hours = double.Parse(Console.ReadLine());

            P1 *= hours;
            P2 *= hours;
            double sum = P1 + P2;
            if (capacityPool >= sum)
            {
                double percentFull = (double)(sum / capacityPool * 100);
                double percentP1 = (double)(P1 / sum * 100);
                double percentP2 = (double)(P2/ sum * 100);

                Console.WriteLine($"The pool is {percentFull:f2}% full. Pipe 1: {percentP1:f2}%. Pipe 2: {percentP2:f2}%.");
            }
            else
            {
                double overflow = (double)(sum - capacityPool);
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {overflow:f2} liters.");
            }

        }
    }
}
