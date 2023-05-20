using System;

namespace P09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint startingYield = uint.Parse(Console.ReadLine());
            uint totalSpice = 0;
            int daysOperated = 0;
            for (uint i = startingYield; 100 <= i; i -= 10)
            {
                totalSpice += i;
                totalSpice -= 26;
                daysOperated++;
            }
            if (totalSpice > 26)
            {
                totalSpice -= 26;
            }
            Console.WriteLine(daysOperated);
            Console.WriteLine(totalSpice);
        }
    }
}
