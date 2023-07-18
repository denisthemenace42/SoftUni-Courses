List<string> bannedWords = Console.ReadLine().Split(", ").ToList();

string text = Console.ReadLine();

foreach (var bannedWord in bannedWords){

    string replace = new string('*',bannedWord.Length);

    text = text.Replace(bannedWord, replace);
}

Console.WriteLine(text);

