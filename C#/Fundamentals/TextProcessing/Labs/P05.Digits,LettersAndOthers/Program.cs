string text = Console.ReadLine();

string letters = string.Empty;
string digits = string.Empty;
string others = string.Empty;

foreach (char x in text)
{

    if (char.IsDigit(x))
    {
        digits += x;
    }

    else if (char.IsLetter(x))
    {
        letters += x;
    }

    else
    {
        others += x;
    }
}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(others);