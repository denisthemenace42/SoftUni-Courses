using System;

namespace P06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;
            while ((input = Console.ReadLine()) != "Finish")
            {
                string movieName = input;
                int freeSeats = int.Parse(Console.ReadLine());
                double counterSeats = 0;
                while (counterSeats < freeSeats)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End") { break; }
                    else if ( ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTickets++;
                    }
                    counterSeats++;
                }
                double percentage = (100*counterSeats)/freeSeats;
                Console.WriteLine($"{movieName} - {percentage:f2}% full.");
            }
            double sumTickets = standardTickets + studentTickets + kidTickets;
            Console.WriteLine($"Total tickets: {sumTickets}");
            Console.WriteLine($"{((100 * studentTickets)/sumTickets):f2}% student tickets.");
            Console.WriteLine($"{((100 * standardTickets) / sumTickets):f2}% standard tickets.");
            Console.WriteLine($"{((100 * kidTickets) / sumTickets):f2}% kids tickets.");
        }
    }
}
