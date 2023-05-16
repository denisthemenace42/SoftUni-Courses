using System.Diagnostics.Metrics;

namespace P05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            string input = string.Empty;
            int counter = 0;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            while ((input = Console.ReadLine()) != password)
            {
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}