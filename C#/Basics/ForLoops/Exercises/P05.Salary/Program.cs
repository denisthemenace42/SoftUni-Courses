using System;

namespace P05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabCount = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < tabCount; i++)
            {
                string name = Console.ReadLine();
                if(name == "Facebook")
                {
                    salary -= 150;
                }
                else if (name == "Instagram")
                {
                    salary -= 100;
                }
                else if (name == "Reddit")
                {
                    salary -= 50;
                }
                else
                {
                    salary += 0;
                }
                if ( salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            Console.WriteLine($"{salary}");
        }
    }
}
