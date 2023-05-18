using System;

namespace P01.Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double avgG = double.Parse(Console.ReadLine());
            Console.Write($"Name: {name},");
            Console.Write($" Age: {age},");
            Console.Write($" Grade: {avgG:f2}");
        }
    }
}
