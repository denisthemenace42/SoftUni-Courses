using System;

namespace P07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine())*width*height;
            int sizeA = size;
            int space = 0;

            while (sizeA > 0)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                int boxes = int.Parse(input);
                space += boxes;
                sizeA -= boxes;
                
            }
            if (sizeA < 0)
            {
                Console.WriteLine($"No more free space! You need {space-size} Cubic meters more. ");
            }
            else
            {
                Console.WriteLine($"{sizeA} Cubic meters left.");
            }
        }
    }
}
