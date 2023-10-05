using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

int counts = int.Parse(Console.ReadLine());

string pattern = @"\|([A-Z]{4,})\|:#([A-Za-z]+ [A-Za-z]+)#";

for (int i = 0; i < counts; i++)
{
    string input = Console.ReadLine();
    Match match = Regex.Match(input, pattern);

    if (match.Success)
    {
        string name = match.Groups[1].Value;
        string title = match.Groups[2].Value;
        int strengthLength = name.Length;
        int armorLength = title.Length;

        Console.WriteLine($"{name}, The {title}");
        Console.WriteLine($">> Strength: {strengthLength}");
        Console.WriteLine($">> Armor: {armorLength}");


    }
    else
    {
        Console.WriteLine("Access denied!");
    }
}


