string input = Console.ReadLine();

Dictionary<char,int> charOccurances = new Dictionary<char, int>();

for (int i =0; i <input.Length; i++){

    char character = input[i];

    if (character == ' '){

        continue;
    }

    if (!charOccurances.ContainsKey(character)){

        charOccurances.Add(character,0);
    }

    charOccurances[character]++;
}

foreach(KeyValuePair<char,int> pair in charOccurances){

    char character = pair.Key;
    int occurances = pair.Value;

    Console.WriteLine($"{character} -> {occurances}");

}

