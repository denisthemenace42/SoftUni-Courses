using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonCount = int.Parse(Console.ReadLine());
            int[] wagons = new int[wagonCount];
            int sum = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                wagons[i] = passengers;
            }
            for (int i = 0; i < wagons.Length; i++)
            {
                sum += wagons[i];
                Console.Write(wagons[i]+ " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
