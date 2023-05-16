using System;

namespace P08.PointOnRectangleBorder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine()); // x3 == x1 && x3 == x2 ---> Border else Outside/Inside
            double y3 = double.Parse(Console.ReadLine()); // y3 == y1 && y3 == y2 ---> border else Outside/Inside
           
             if (x3 < x1 && x3 < x2)
            {
                Console.WriteLine("Inside / Outside");
            }
            else if (x3 > x1 && x3 > x2)
            {
                Console.WriteLine("Inside / Outside");
            }
            else if (y3 < y1 && y3 < y2)
            {
                Console.WriteLine("Inside / Outside");
            }
             else if (y3 > y1 && y3 >y2)
            {
                Console.WriteLine("Inside / Outside");
            }
            else if (x3 == x1)
            {
                Console.WriteLine("Border");
            }
            else if (x3 == x2)
            {
                Console.WriteLine("Border");
            }
            else if (y3 == y1)
            {
                Console.WriteLine("Border");
            }
            else if (y3 == y2)
            {
                Console.WriteLine("Border");
            }
            else 
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
