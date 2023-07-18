using System;
using System.IO;

namespace P07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square") 
            {
            double num = double.Parse(Console.ReadLine());
                 num = num * num;
                Console.WriteLine("{0:F3}",num);
            }
            else if (figure == "rectangle")
            {
                double numA = double.Parse(Console.ReadLine());
                double numB = double.Parse(Console.ReadLine());
                double numS = numA * numB;
                Console.WriteLine("{0:F3}", numS);
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                radius = Math.PI * radius * radius;
                Console.WriteLine("{0:F3}", radius);
            }
            else if (figure == "triangle")
            {
                double numA = double.Parse(Console.ReadLine());
                double numB = double.Parse(Console.ReadLine());
                double numS = (numA * numB)/2;
                Console.WriteLine("{0:F3}", numS);
            }
        }
    }
}
