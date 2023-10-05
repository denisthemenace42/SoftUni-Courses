using System.Globalization;
using System.Text;
using System;

int count = int.Parse(Console.ReadLine());
Stack<int> numbers = new Stack<int>();
for (int i = 0; i<count;i++)
{
    int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

    if (commands[0] == 1)
    {
        numbers.Push(commands[1]);
    }

    else if (commands[0] == 2 && numbers.Count != 0)
    {
        numbers.Pop();
    }

    else if (commands[0] == 3 && numbers.Count != 0)
    {
        Console.WriteLine(numbers.Max());
    }

    else if (commands[0] == 4 && numbers.Count != 0) 
    {
       
        Console.WriteLine(numbers.Min());
    }
}

Console.WriteLine(String.Join(", ", numbers));