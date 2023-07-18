using System;

namespace P01.Encrypt_Sort_andPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int vowelSum = 0;
            int consonantSum = 0;
            int sum = 0;
            string vowels = "aAoOiIeEuU";
            int[] arrayOfSums = new int[n];
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                for (int j = 0; name.Length > j; j++)
                {
                    char currentLetter = name[j];
                    if (vowels.Contains(currentLetter))
                    {
                        vowelSum += currentLetter * name.Length;
                    }
                    else
                    {
                        consonantSum += currentLetter / name.Length;
                    }
                }

                sum = vowelSum + consonantSum;
                arrayOfSums[i] = sum;
                vowelSum = 0;
                consonantSum = 0;
                sum = 0;

            }
            Array.Sort(arrayOfSums);
            for (int i = 0; i < arrayOfSums.Length; i++)
            {
                Console.WriteLine(arrayOfSums[i]);
            }

        }
    }
}
