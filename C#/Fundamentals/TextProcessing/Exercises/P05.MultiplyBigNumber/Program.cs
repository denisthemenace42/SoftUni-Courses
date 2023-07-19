
string input = Console.ReadLine();
int multiplier = int.Parse(Console.ReadLine());
int addNum = 0;
for (int i = 0; i < input.Length; i++)
{
    char ch = input[i];
    if (ch != '0')
    {
        int index = i;
        input = input.Substring(index);
        break;
    }
}
if (multiplier == 0)
{
    Console.WriteLine(0);
    return;
}

var exitNum = new System.Text.StringBuilder();

char[] inputNum = input.ToCharArray();

for (int i = inputNum.Length - 1; i >= 0; i--)
{
    int currentNum = ((inputNum[i] - '0') * multiplier) + addNum;
    addNum = currentNum / 10;
    currentNum %= 10;
    exitNum.Append(currentNum);
}
if (addNum > 0)
{
    exitNum.Append(addNum);
}
char[] exitNumArray = exitNum.ToString().ToCharArray();
Array.Reverse(exitNumArray);
Console.WriteLine(new string(exitNumArray));
