using System;

namespace P07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            double g1 = 0;
            double g2= 0;
            double g3= 0;
            double g4= 0;
            double g5= 0;
            for (int i = 0; i < groupCount; i++)
            {
                int groupMembers = int.Parse(Console.ReadLine());
                if (groupMembers <= 5)
                {
                    g1 += groupMembers;
                }
                else if (groupMembers <= 12)
                {
                    g2 += groupMembers;
                }
                else if (groupMembers <= 25)
                {
                    g3 += groupMembers;
                }
                else if (groupMembers <= 40)
                {
                    g4 += groupMembers;
                }
                else if (groupMembers >= 41)
                {
                    g5 += groupMembers;
                }
            }
            double endSum = g1+g2+g3+g4+g5;
            Console.WriteLine($"{g1 / endSum * 100:f2}%");
            Console.WriteLine($"{g2 / endSum * 100:f2}%");
            Console.WriteLine($"{g3 / endSum * 100:f2}%");
            Console.WriteLine($"{g4 / endSum * 100:f2}%");
            Console.WriteLine($"{g5 / endSum * 100:f2}%");
        }
    }
}
