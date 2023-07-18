using System;


namespace P05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination;
            while ((destination = Console.ReadLine()) != "End")
            {
                double budget = double .Parse(Console.ReadLine());
                double savedSum = 0;
                while (savedSum < budget)
                {
                    savedSum += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
