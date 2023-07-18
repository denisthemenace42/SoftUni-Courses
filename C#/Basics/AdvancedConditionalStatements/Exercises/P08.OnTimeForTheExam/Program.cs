using System;
using System.ComponentModel.Design;

namespace P08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine()); // 11
            int examMinutes = int.Parse(Console.ReadLine()); // 00
            int arrivalHour = int.Parse(Console.ReadLine()); // 10
            int arrivalMinutes = int.Parse(Console.ReadLine()); // 59

            int examTime = (examHour * 60) + examMinutes;
            int arrivalTime = (arrivalHour * 60) + arrivalMinutes;

            if (arrivalTime > examTime) // Late
            {
                Console.WriteLine("Late");
                if (arrivalTime - examTime < 60)
                {
                    Console.WriteLine($"{arrivalTime - examTime} minutes after the start");
                }
                else
                {
                    int hours = (arrivalTime - examTime) / 60;
                    int minutes = (arrivalTime - examTime) % 60;
                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }
            }
            else if (examTime == arrivalTime || examTime - arrivalTime <= 30) // On time
            {
                Console.WriteLine("On time");
                if (examTime - arrivalTime != 0)
                {
                    int minutes = examTime - arrivalTime;
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else if (examTime - arrivalTime > 30) // Early
            {
                Console.WriteLine("Early");
                if (examTime - arrivalTime < 60)
                {
                    int minutes = examTime - arrivalTime;
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else
                {
                    int hours = (examTime - arrivalTime)/60;
                    int minutes = (examTime - arrivalTime) % 60;
                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }
            }
        }
    }
}
