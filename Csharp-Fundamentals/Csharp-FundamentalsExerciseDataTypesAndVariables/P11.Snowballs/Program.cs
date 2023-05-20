using System;
using System.Numerics;

namespace P11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           byte snowballCount = byte.Parse(Console.ReadLine());
           BigInteger snowballValue = int.MinValue;
           short snowballSnow = short.MinValue;
           short snowballTime = short.MinValue;
           byte snowballQuality = byte.MinValue;
            for (int i = 0; i < snowballCount; i++)
            {
                short snowballSnowF = short.Parse(Console.ReadLine());
                short snowballTimeF = short.Parse(Console.ReadLine());
                byte snowballQualityF = byte.Parse(Console.ReadLine());

                BigInteger snowballValueF = BigInteger.Pow(snowballSnowF / snowballTimeF,snowballQualityF);
                
                if (snowballValueF > snowballValue)
                {
                    snowballValue = snowballValueF;
                    snowballQuality = snowballQualityF;
                    snowballSnow = snowballSnowF;
                    snowballTime = snowballTimeF;
                }
            }
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");
        }
    }
}
