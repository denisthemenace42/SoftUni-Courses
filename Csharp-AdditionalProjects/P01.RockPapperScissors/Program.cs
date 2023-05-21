using System;

namespace P01.RockPapperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Scissors = "scissors";
            const string Paper = "paper";
            const string Rock = "rock";
            int computerScore = 0;
            int yourScore = 0;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Choose between [r]ock, [p]aper or [s]cissors: ");
                string playerMove = Console.ReadLine();
                playerMove = playerMove.ToLower();

                if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = Scissors;
                }
                else if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try Again!");
                    continue;
                }
                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);
                string computerMove = "";
                
                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }
                if ((playerMove == Rock && computerMove == Scissors) ||
                   (playerMove == Scissors && computerMove == Paper) ||
                   (playerMove == Paper && computerMove == Rock))
                {
                    yourScore += 1;
                    Console.WriteLine($"YOU: {playerMove}");
                    Console.WriteLine($"COMPUTER: {computerMove}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You are the winner!");
                }
                else if ((playerMove == Paper && computerMove == Scissors) ||
                          (playerMove == Scissors && computerMove == Rock) ||
                            (playerMove == Rock && computerMove == Paper))
                {
                    computerScore += 1;
                    Console.WriteLine($"YOU: {playerMove}");
                    Console.WriteLine($"COMPUTER: {computerMove}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                }
                else
                {
                    Console.WriteLine($"YOU: {playerMove}");
                    Console.WriteLine($"COMPUTER: {computerMove}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("This game was draw.");
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----------SCOREBOARD-----------");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"YOUR SCORE: {yourScore} COMPUTER SCORE: {computerScore}");
                Console.WriteLine("Do you wanna play again? Y/N");
                string again = string.Empty;
                while ((again=Console.ReadLine()) != "Y" && again != "y")
                {
                    if (again == "N" || again == "n")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please choose between Yes/No.");
                       
                    }
                }
                
            }
        }
    }
}
