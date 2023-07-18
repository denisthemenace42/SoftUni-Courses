List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input;

while ((input = Console.ReadLine()) != "end"){

    string[] tokens = input.Split();
    switch(tokens[0]){

        case "Add":
        int add = int.Parse(tokens[1]);
        numbers.Add(add);
        break;
        case "Remove":
        int remove = int.Parse(tokens[1]);
        numbers.Remove(remove);
        break;
        case "RemoveAt":
        int index = int.Parse(tokens[1]);
        numbers.RemoveAt(index);
        break;
        case "Insert":
        int number = int.Parse(tokens[1]);
        int index2 = int.Parse(tokens[2]);
        numbers.Insert(index2,number);
        break;
    }
}
Console.WriteLine(string.Join(" ",numbers));
