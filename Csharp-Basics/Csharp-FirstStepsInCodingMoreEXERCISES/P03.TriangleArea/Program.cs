using System;

namespace P01.TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            

            double area = b1*b2/2;
            Console.WriteLine("{0:F2}", area);
        }
    }
}
