List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input;

while ((input = Console.ReadLine()) != "end"){

    string[] tokens = input.Split();

    switch (tokens[0]){

        case "Delete":
        int remove = int.Parse(tokens[1]);
        for (int i = 0; i <= numbers.Count - 1; i ++){

           if (numbers[i] == remove){
            numbers.Remove(remove);
           }
        }
        break;
        case "Insert":
        int currentNumber = int.Parse(tokens[1]);
        int index = int.Parse(tokens[2]);
        numbers.Insert(index,currentNumber);
        break;

    }
}

Console.WriteLine(string.Join(" ", numbers));


