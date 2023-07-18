using System;

namespace P06.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double returnMoney = double.Parse(Console.ReadLine())*100;
            int counter = 0;
            while (returnMoney > 0)
            {
                if (returnMoney >= 200)
                {
                    returnMoney -= 200;
                }
                else if (returnMoney >= 100)
                {
                    returnMoney -= 100;
                }
                else if (returnMoney >= 50)
                {
                    returnMoney -= 50;
                }
                else if (returnMoney >= 20)
                {
                    returnMoney -= 20;
                }
                else if (returnMoney >= 10)
                {
                    returnMoney -= 10;
                }
                else if (returnMoney >= 5)
                {
                    returnMoney -= 5;
                }
                else if (returnMoney >= 2)
                {
                    returnMoney -= 2;
                }
                else if (returnMoney >= 1)
                {
                    returnMoney = 0;
                }
                else
                {
                    break; 
                }
                counter++;
            }
            Console.WriteLine(counter);

        }
    }
}
