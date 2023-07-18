using System;

namespace P06.BasketballTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double win = 0;
            double loss = 0;
            while ((input = Console.ReadLine()) != "End of tournaments")
            {
                    int gameCount = int.Parse(Console.ReadLine());
                   
                    for (int i = 1; i <= gameCount; i++)
                    {
                        int gamePointsDesi = int.Parse(Console.ReadLine());
                        int gamePointsEnemy = int.Parse(Console.ReadLine());
                        if (gamePointsDesi > gamePointsEnemy)
                        {
                            win++;
                            
                            gamePointsDesi -= gamePointsEnemy;
                            Console.WriteLine($"Game {i} of tournament {input}: win with {gamePointsDesi} points.");
                        }
                        else
                        {
                            loss++;
                            
                            gamePointsEnemy -= gamePointsDesi;
                            Console.WriteLine($"Game {i} of tournament {input}: lost with {gamePointsEnemy} points.");
                        }
                    }

            }
            double counter = win + loss;
            Console.WriteLine($"{(win/counter)*100:f2}% matches win");
            Console.WriteLine($"{(loss/counter)*100:f2}% matches lost");

        }
    }
}
