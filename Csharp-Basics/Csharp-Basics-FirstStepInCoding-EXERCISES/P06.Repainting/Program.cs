using System;

namespace P06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonReq = int.Parse(Console.ReadLine())+2;
            double paintReq = double.Parse(Console.ReadLine())*1.1;
            
            int PaintThinnerReq = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nylon = nylonReq * 1.50;
            double paint = paintReq * 14.50;
            double paintThinner = PaintThinnerReq * 5.00;
            double materials = nylon + paint + paintThinner + 0.40;
            double workingPrice = materials * 0.3 * hours;
            double totalSum = workingPrice + materials;
            
            Console.WriteLine(totalSum);

        }
    }
}
