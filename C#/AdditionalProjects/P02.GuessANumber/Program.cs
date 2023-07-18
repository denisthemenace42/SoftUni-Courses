using System;
using System.Drawing;

namespace P02.GuessANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Random random = new Random();
                int health = 10;
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your starting health is {health}. For every wrong guess you will loose 1 health.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Level 1. Guess a number ( 1-100 ): ");
                int randomNumber = random.Next(1, 101);
                while (true)
                {
                    if (health <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("You lost! ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"The correct number is: {randomNumber}");
                        return; 
                    }
                    string playerInput = Console.ReadLine();
                    bool isValid = int.TryParse(playerInput, out int guessedNumber);
                    if (isValid)
                    {

                        if (guessedNumber > randomNumber)
                        {
                            health -= 1;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"-------------------------------Too High! Your current health is: {health}");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Level 1. Guess a number ( 1-100 ): ");
                        }
                        else if (guessedNumber < randomNumber)
                        {
                            health -= 1;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"--------------------------------Too Low! Your current health is: {health}");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Level 1. Guess a number ( 1-100 ): ");
                        }
                        else if (guessedNumber == randomNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("");
                            Console.WriteLine("Congratulations! You guessed it!");
                            Console.WriteLine("For passing this level you receive 5 health points! Keep going!");
                            health += 5;
                            Console.WriteLine($"Your current health is {health}.");
                            Console.WriteLine("");
                            break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Invalid input");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Level 1. Guess a number ( 1-100 ): ");
                     }

                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Level 2. Guess a number ( 1-500 ): ");
                int randomNumber2 = random.Next(1, 501);
                while (true)
                {
                    if (health <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("You lost! ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"The correct number is: {randomNumber}");
                        return;
                    }
                    string playerInput = Console.ReadLine();
                    bool isValid = int.TryParse(playerInput, out int guessedNumber);

                    if (isValid)
                    {
                        if (guessedNumber > randomNumber2)
                        {
                            health -= 1;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"-------------------------------Too High! Your current health is: {health}");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Level 2. Guess a number ( 1-500 ): ");
                        }
                        else if (guessedNumber < randomNumber2)
                        {
                            health -= 1;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"-------------------------------Too Low! Your current health is: {health}");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Level 2. Guess a number ( 1-500 ): ");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Congratulations, you passed level 2! You guessed the number!");
                            Console.WriteLine("For passing this level you receive 6 health points! Keep going!");
                            health += 6;
                            Console.WriteLine($"Your current health is {health}.");
                            Console.WriteLine("");
                            break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Invalid input");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Level 2. Guess a number ( 1-500 ): ");
                     }

                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Level 3. Guess a number ( 1-1000 ): ");
                int randomNumber3 = random.Next(1, 1001);
                while (true)
                {
                    if (health <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("You lost! ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"The correct number is: {randomNumber}");
                        return;
                    }
                    string playerInput = Console.ReadLine();
                    bool isValid = int.TryParse(playerInput, out int guessedNumber);

                    if (isValid)
                    {
                        if (guessedNumber > randomNumber3)
                        {
                            health -= 1;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"-------------------------------Too High! Your current health is: {health}");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Level 3. Guess a number ( 1-1000 ): ");
                        }
                        else if (guessedNumber < randomNumber3)
                        {
                            health -= 1;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"-------------------------------Too Low! Your current health is: {health}");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Level 3. Guess a number ( 1-1000 ): ");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Congratulations, you passed level 3! You guessed the number!");
                            Console.WriteLine("For passing this level you receive 6 health points! Keep going!");
                            health += 6;
                            Console.WriteLine($"Your current health is {health}.");
                            Console.WriteLine("");
                            break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Invalid input");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Level 3. Guess a number ( 1-1000 ): ");
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Level 4. Guess a number ( 1-10000 ): ");
                int randomNumber4 = random.Next(1, 10001);
                while (true)
                {
                    if (health <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("You lost! ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"The correct number is: {randomNumber}");
                        return;
                    }
                    string playerInput = Console.ReadLine();
                    bool isValid = int.TryParse(playerInput, out int guessedNumber);

                    if (isValid)
                    {
                        if (guessedNumber > randomNumber3)
                        {
                            health -= 1;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"-------------------------------Too High! Your current health is: {health}");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Level 4. Guess a number ( 1-10000 ): ");
                        }
                        else if (guessedNumber < randomNumber3)
                        {
                            health -= 1;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"-------------------------------Too Low! Your current health is: {health}");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Level 4. Guess a number ( 1-10000 ): ");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Congratulations, you passed the last level! You guessed the number!");
                            Console.WriteLine($"Your current health is {health}.");
                            Console.WriteLine("");
                            return;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Invalid input");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Level 4. Guess a number ( 1-10000 ): ");
                    }
                }   
        }
    }
}
