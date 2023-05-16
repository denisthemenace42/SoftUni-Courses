using System;

namespace P06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentCharacter = input[i];
                if (currentCharacter == 'a')
                {
                    sum += 1;
                }
                else if (currentCharacter == 'e')
                {
                    sum += 2;
                }
                else if (currentCharacter == 'i')
                {
                    sum += 3;
                }
                else if (currentCharacter == 'o')
                {
                    sum += 4;
                }
                else if (currentCharacter == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
