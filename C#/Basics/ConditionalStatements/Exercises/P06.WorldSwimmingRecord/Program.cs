using System;

namespace P06.WorldSwimmingRecord
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            double secondsRecord = double.Parse(Console.ReadLine()); 
            double meters = double.Parse(Console.ReadLine()); 
            double speedPerMeter = double.Parse(Console.ReadLine()); 
            double ivanSpeed = meters * speedPerMeter;
            double slowness = Math.Floor(meters / 15);
            slowness = slowness * 12.5;
            ivanSpeed = ivanSpeed + slowness;
            double requiredTime = ivanSpeed - secondsRecord;
            if (ivanSpeed >= secondsRecord)
            {
                Console.WriteLine($"No, he failed! He was {requiredTime:f2} seconds slower.");
            }
            else if (ivanSpeed < secondsRecord)
             {
                Console.WriteLine($" Yes, he succeeded! The new world record is {ivanSpeed:f2} seconds.");
            }
        }
    }
}
