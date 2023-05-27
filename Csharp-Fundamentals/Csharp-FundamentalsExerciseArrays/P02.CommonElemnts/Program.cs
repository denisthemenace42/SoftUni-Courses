using System;
using System.Linq;

namespace P02.CommonElemnts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(" ");
            foreach(string same in secondArray)
            {
                if (firstArray.Contains(same))
                {
                    Console.Write(same + " ");
                }
            }
        }
    }
}
