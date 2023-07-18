using System;

namespace P05.TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            if (w <=100 && h >= 3)
            {
                h = h - 1.0;
                h = Math.Floor(h / 0.7);
                w = Math.Floor(w / 1.2);
                double spaces = w * h - 3;
                Console.WriteLine(spaces);
            }
            
        }
    }
}
