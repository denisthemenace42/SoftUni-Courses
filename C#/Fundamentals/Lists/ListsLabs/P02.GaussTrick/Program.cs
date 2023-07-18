List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

int counts = numbers.Count / 2;

List<int> result = new List<int>();

for (int i = 0; i < counts; i ++){

    result.Add(numbers[i] += numbers[numbers.Count - i - 1]);
    
}

if (numbers.Count % 2 == 1){
    
    result.Add(numbers[numbers.Count / 2]);
}

Console.WriteLine(string.Join(" ", result));
