using System;

namespace P07.HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xHeight =  double.Parse(Console.ReadLine());
            double yWidthSideWall = double.Parse(Console.ReadLine());
            double hHeightRoof = double.Parse(Console.ReadLine());
            double windows = 1.5 * 1.5;
            double door = 1.2 * 2;
            double sideWalls = xHeight * yWidthSideWall;
            double twoWalls = 2 * sideWalls - 2 * windows;
            double frontWalls = xHeight * xHeight;
            double frontAndBackWalls = 2 * frontWalls - door;
            double totalAreaWalls = twoWalls + frontAndBackWalls;
            double litreRequiredGreen = totalAreaWalls / 3.4;

            double doubleRoof = 2 * sideWalls;
            double triangleRoof = 2 * (xHeight * hHeightRoof / 2);
            double secondTotalArea = doubleRoof + triangleRoof;
            double litreRequiredRed = secondTotalArea / 4.3;

            Console.WriteLine("{0:f2}",litreRequiredGreen);
            Console.WriteLine("{0:f2}",litreRequiredRed);
        }
    }
}
