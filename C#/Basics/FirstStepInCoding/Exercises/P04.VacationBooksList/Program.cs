using System;

namespace P04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се отпечата на конзолата броят часове, които Жоро трябва да отделя за четене всеки ден.
            int pages = int.Parse(Console.ReadLine());
            int readingPace = int.Parse(Console.ReadLine());
            int daysToFinish = int.Parse(Console.ReadLine());

            int pagesPerDay = pages / daysToFinish;
            int hoursToFinish = pagesPerDay / readingPace;

            Console.WriteLine(hoursToFinish);
        }
    }
}
