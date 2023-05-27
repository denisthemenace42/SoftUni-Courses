using System;
using System.Linq;

namespace P04.ReverseArrayOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            for (int i  = array.Length -1 ; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
         
        }
    }
}
