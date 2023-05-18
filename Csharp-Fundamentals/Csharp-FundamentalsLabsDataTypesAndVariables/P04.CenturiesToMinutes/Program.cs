﻿namespace P04.CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422);
            ulong hours = (ulong)(days * 24);
            decimal minutes = (decimal)(hours * 60);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}