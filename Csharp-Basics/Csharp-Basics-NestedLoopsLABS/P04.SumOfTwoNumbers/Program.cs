using System;
using System.Diagnostics.Tracing;

namespace P04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            bool flag = false;
            int counter = 0;
            int d1 = 0;
            int d2 = 0;
            for (d1 = start; d1 <=end; d1++)
            {
                for (d2=start; d2 <= end; d2++)
                {
                    counter++;
                    if (d1+d2 == magicNum)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine($"Combination N:{counter} ({d1} + {d2} = {magicNum})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
