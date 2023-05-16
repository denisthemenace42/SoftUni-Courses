using System;

namespace P06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            double sum = 0.0;
            string type = string.Empty;
            switch (op)
            {
                case '+':
                    sum = number1 + number2;
                    if (sum % 2 == 0)
                    {
                        type = "even";
                    }
                    else
                    {
                        type = "odd";
                    }
                    Console.WriteLine($"{number1} + {number2} = {sum} - {type}");
                    break;
                case '-':
                    sum = number1 - number2;
                    if (sum % 2 == 0)
                    {
                        type = "even";
                    }
                    else
                    {
                        type = "odd";
                    }
                    
                    Console.WriteLine($"{number1} - {number2} = {sum} - {type}");
                    break;
                case '*':
                    sum = number1 * number2;
                    if (sum % 2 == 0)
                    {
                        type = "even";
                    }
                    else
                    {
                        type = "odd";
                    }
                    
                    Console.WriteLine($"{number1} * {number2} = {sum} - {type}");

                    break;
                case '/':
                    sum = number1 / number2;
                    if (number1 == 0 || number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                        break;
                    }
                    Console.WriteLine($"{number1} / {number2} = {sum:f2}");
                    break;
                case '%':
                    sum = number1 % number2;
                    if (number1 == 0 || number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                        break;
                    }
                    
                    Console.WriteLine($"{number1} % {number2} = {sum}");
                    break;
            }
        }
    }
}
