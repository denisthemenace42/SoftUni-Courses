var words = new Dictionary<string,List<string>>();

int lines = int.Parse(Console.ReadLine()) * 2;


for (int i = 0; i<lines; i++){

    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

     if (word != null && synonym != null)
            {
                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }

                words[word].Add(synonym);
            }
}

foreach(var pair in words){

    string word = pair.Key;
    List<string> synonymList = pair.Value;

    Console.WriteLine($"{word} - {string.Join(", ", synonymList)}");
}