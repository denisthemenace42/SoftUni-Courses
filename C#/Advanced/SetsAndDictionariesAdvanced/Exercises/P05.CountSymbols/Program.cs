SortedDictionary<char,int> charsCount = new();

string input = Console.ReadLine();

foreach(char ch in input)
{
    if (!charsCount.ContainsKey(ch))
    {
        charsCount.Add(ch,0);
    }

    charsCount[ch]++;
}

foreach (var charCount in charsCount)
{
    Console.WriteLine($"{charCount.Key}: {charCount.Value} time/s");
}