
string expression = Console.ReadLine();

Stack<int> openingBrackets = new Stack<int>();

for (int i = 0; i < expression.Length; i++)
{
    if (expression[i] == '(')
    {
        openingBrackets.Push(i);
        
    }

    if (expression[i] == ')')
    {
        int openingBracketIndex = openingBrackets.Pop();

        Console.WriteLine(expression.Substring(openingBracketIndex + 1, i - openingBracketIndex-1));
    }

}