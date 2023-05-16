using System;

namespace P04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jurryCount = int.Parse(Console.ReadLine());
            string input;
            int counter = 0;
            double allSum = 0;
            while ((input = Console.ReadLine()) != "Finish") 
            {
                string namePres = input;
                double sum = 0;
                for (int i =0; i < jurryCount; i++)
                {
                    double score = double.Parse(Console.ReadLine());
                    sum  += score;
                    allSum += score;
                    counter++;
                }
                sum  =  sum / jurryCount;
                Console.WriteLine($"{namePres} - {sum:f2}.");
            }
            Console.WriteLine($"Student's final assessment is {(allSum/counter):f2}.");
        }
    }
}
