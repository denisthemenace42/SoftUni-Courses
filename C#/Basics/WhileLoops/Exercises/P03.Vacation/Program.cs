using System;

namespace P03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyRequired = double.Parse(Console.ReadLine());
            double moneyBalance = double.Parse(Console.ReadLine());
            int dayCounter = 0;
            int spendingCounter = 0;
            while (moneyBalance < moneyRequired && spendingCounter < 5) 
            {
                dayCounter++;
                string type = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                if (type == "save")
                {
                    moneyBalance += sum;
                    spendingCounter = 0;
                }
                if (type == "spend")
                {
                    spendingCounter++;
                    moneyBalance -= sum;
                    if (moneyBalance < 0)
                    {
                        moneyBalance = 0;
                    }
                }
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(dayCounter);

            }
            if (moneyRequired <= moneyBalance)
            {
                Console.WriteLine($"You saved the money for {dayCounter} days.");

            }
        }
    }
}
