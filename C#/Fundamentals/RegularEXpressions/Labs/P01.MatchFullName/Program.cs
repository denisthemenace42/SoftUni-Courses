using System.Text.RegularExpressions;
string input = Console.ReadLine();

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

MatchCollection matchedNames = Regex.Matches(input, pattern);

foreach (Match name in matchedNames)
{

    Console.Write(name.Value + " ");
}

Console.WriteLine();