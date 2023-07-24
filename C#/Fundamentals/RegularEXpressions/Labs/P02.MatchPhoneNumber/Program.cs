using System.Text.RegularExpressions;
string input = Console.ReadLine();

string pattern = @"\+([359]+)([- ])2(\2)(\d{3})(\2)(\d{4})\b";

var phoneMatches = Regex.Matches(input, pattern);

var matchedPhones = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

Console.WriteLine(string.Join(", ", matchedPhones));
