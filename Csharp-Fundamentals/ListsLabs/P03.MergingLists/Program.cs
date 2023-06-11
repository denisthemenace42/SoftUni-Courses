using System;
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> result = new List<int>();

int counts = Math.Max(numbers.Count, numbers2.Count);

for (int i = 0; i < counts; i++){

    if (i<numbers.Count){

        result.Add(numbers[i]);
    }

    if(i<numbers2.Count){

        result.Add(numbers2[i]);
    }
}

Console.WriteLine(string.Join(" ", result));