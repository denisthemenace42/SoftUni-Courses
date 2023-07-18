using System;

namespace P10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); //pokePower
            int M = int.Parse(Console.ReadLine()); // pokeTargets
            int Y = int.Parse(Console.ReadLine()); // exhastuionFactor
            int pokedCount = 0; // count of poked targets
            int originalN = N;

            while(N>=M) // M-N = until N becomes less than M ( for every subtraction pokedCount+1 )
            {
                N -= M;
                pokedCount++;
                double percent = originalN * 0.5d;
                if(percent == N && Y != 0)
                {
                    N /= Y;  
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(pokedCount);
        }
    }
}
