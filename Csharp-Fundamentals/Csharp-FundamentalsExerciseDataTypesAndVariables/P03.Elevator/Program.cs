using System;

namespace P03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)peopleCount / capacity);
            Console.WriteLine(courses);
        }
    }
}
