﻿using System.Text;
string[] words = Console.ReadLine().Split();

StringBuilder result = new StringBuilder();

foreach (var word in words){

    int count = word.Length;

    for (int i =0; i < count; i ++){


        result.Append(word);
    }
}

Console.WriteLine(result);