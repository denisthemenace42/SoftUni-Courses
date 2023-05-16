using System;

namespace P07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string nameArch = Console.ReadLine();
           int numberProj = int.Parse(Console.ReadLine());
            int time = 3 * numberProj;
            
            Console.WriteLine($"The architect {nameArch} will need {time} hours to complete {numberProj} project/s.");
        }
    }
}
