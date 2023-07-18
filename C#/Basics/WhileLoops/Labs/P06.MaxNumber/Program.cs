using System;

namespace P06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); 
            int maxNum = int.MinValue;
            while (input != "Stop")
            { 
                int newNum = int.Parse(input);
                input = Console.ReadLine();
                if(newNum > maxNum)
                {
                    maxNum = newNum;
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
