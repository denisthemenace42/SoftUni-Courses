string expression = Console.ReadLine();

string[] tokens = expression.Split(' ');

Stack<string> stack = new Stack<string>(tokens.Reverse());

int result = int.Parse(stack.Pop());

while (stack.Count != 0)
{
    string operation = stack.Pop();
    int number = int.Parse(stack.Pop());

    if (operation == "+")
    {
        result += number;
    }
    else if (operation == "-")
    {
        result -= number;
    }
}

Console.WriteLine(result);



