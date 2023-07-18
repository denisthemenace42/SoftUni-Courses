using System;

namespace P01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            bool favBook = false;
            int counter = 0;
            string nextBookName = Console.ReadLine();
            while (nextBookName != "No More Books")
            {
                if (nextBookName == bookName)
                {
                    favBook = true;
                    break;
                }
                counter++;
                nextBookName = Console.ReadLine();
            }
            if (favBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
