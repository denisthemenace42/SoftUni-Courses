string word1 = Console.ReadLine();
string word2 = Console.ReadLine();

int index = word2.IndexOf(word1);

while (index != -1){

    word2 = word2.Remove(index, word1.Length);

    index = word2.IndexOf(word1);
}

Console.WriteLine(word2);