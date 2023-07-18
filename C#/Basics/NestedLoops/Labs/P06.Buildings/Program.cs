using System;

namespace P06.Buildings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            
            for (int currFl = floors; currFl>=1; currFl--)
            {

                for (int currAp = 0; currAp < rooms; currAp++)
                {
                    if (currFl == floors)
                    {
                        Console.Write($"L{currFl}{currAp} ");
                    }
                    else if (currFl % 2 == 0)
                    {
                        Console.Write($"O{currFl}{currAp} ");
                    }
                    else
                    {
                        Console.Write($"A{currFl}{currAp} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
  