using System;

namespace P08.CircleAreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine("{0:F2}",area);
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("{0:F2}",perimeter);
        }
    }
}
