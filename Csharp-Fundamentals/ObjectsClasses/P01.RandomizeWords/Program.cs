string[] words = Console.ReadLine().Split().ToArray();

Random  rnd = new Random();

for (int i = 0; i < words.Length; i++){
    
    string valueAtIndex = words[i];
    int randomIndex = rnd.Next(0,words.Length);
    string randomValueAtIndex = words[randomIndex];
     
    words[i] = randomValueAtIndex;
    words[randomIndex] = valueAtIndex;
}

foreach(string word in words){

    Console.WriteLine(word);
}
