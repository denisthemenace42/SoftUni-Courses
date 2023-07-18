using System;

namespace P04.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int groupsCount = int.Parse(Console.ReadLine());
            int allPpl = 0;
            double gr1 = 0;
            double gr2 = 0;
            double gr3 = 0;
            double gr4 = 0;
            double gr5 = 0;
            for (int i = 0; i < groupsCount; i++)
            {
                int pplCount = int.Parse(Console.ReadLine());
                allPpl += pplCount;
                if(pplCount <= 5)
                {
                    gr1 += pplCount;
                }
                else if (pplCount <= 12)
                {
                    gr2 += pplCount;
                }
                else if(pplCount <= 25)
                {
                    gr3 += pplCount;
                }
                else if (pplCount<= 40)
                {
                    gr4 += pplCount;
                }
                else if (pplCount >= 41)
                {
                    gr5 += pplCount;    
                }
            }
            Console.WriteLine($"{((gr1 / allPpl) * 100):f2}%");
            Console.WriteLine($"{((gr2 / allPpl) * 100):f2}%");
            Console.WriteLine($"{((gr3 / allPpl) * 100):f2}%");
            Console.WriteLine($"{((gr4 / allPpl) * 100):f2}%");
            Console.WriteLine($"{((gr5 / allPpl) * 100):f2}%");
        }
    }
}
