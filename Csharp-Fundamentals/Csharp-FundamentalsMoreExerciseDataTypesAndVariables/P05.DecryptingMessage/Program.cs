using System;

namespace P05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberLines = int.Parse(Console.ReadLine());
            for(int i = 0; i < numberLines; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int decrypt = (int)input + key;
                Console.Write((char)decrypt);
            }
        }
    }
}
