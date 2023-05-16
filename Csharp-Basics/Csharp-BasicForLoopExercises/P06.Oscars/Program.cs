using System;

namespace P06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int jurry = int.Parse(Console.ReadLine());
          

            for (int i = 0; i < jurry; i++)
            {
                string jurryName = Console.ReadLine();
                double jurryPoints = double.Parse(Console.ReadLine());

                pointsAcademy = pointsAcademy + ((jurryName.Length * jurryPoints) / 2);
                if ( pointsAcademy >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsAcademy:f1}!");
                    return;
                }
            }
            Console.WriteLine($"Sorry, {actorName} you need {1250.5 - pointsAcademy:f1} more!");
        }
    }
}
