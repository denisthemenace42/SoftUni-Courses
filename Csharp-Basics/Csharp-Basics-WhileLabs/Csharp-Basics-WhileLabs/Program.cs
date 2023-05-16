using System;

namespace Csharp_Basics_WhileLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                Console.WriteLine(input);
                input = Console.ReadLine();
                
            }
        }
    }
}
