List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> originalList = new List<int>();

originalList.AddRange(numbers);


string input;

while ((input = Console.ReadLine()) != "end"){

    string[] tokens = input.Split();
    switch(tokens[0]){

        case "Contains":
        int contains = int.Parse(tokens[1]);
        if (numbers.Contains(contains)){

            Console.WriteLine("Yes");
        }
        else{

            Console.WriteLine("No such number");
        };
        break;
        case "PrintEven":
        List<int> resultsEven = new List<int>();

        for (int i = 0; i <= numbers.Count - 1; i++){

         if (numbers[i] % 2 == 0){

        resultsEven.Add(numbers[i]);
         }
        }
        Console.WriteLine(string.Join(" ",resultsEven));
        break;
        case "PrintOdd":
        List<int> resultsOdd = new List<int>();

        for (int i = 0; i <= numbers.Count - 1; i++){

         if (numbers[i] % 2 != 0){

        resultsOdd.Add(numbers[i]);
         }
        }
        Console.WriteLine(string.Join(" ",resultsOdd));
        break;
        case "GetSum":
        int sum = 0;
        for (int i = 0; i <= numbers.Count - 1; i++){

            sum += numbers[i];
        }
        Console.WriteLine(sum);
        break;
        case "Filter":
        string condition = tokens[1];
        int digit = int.Parse(tokens[2]);
        Filter(condition,digit);
        break;
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
bool isEqual = numbers.All(originalList.Contains) && originalList.All(numbers.Contains);
if (isEqual != true){
Console.WriteLine(string.Join(" ",numbers));
}


void Filter(string condition, int digit){

    switch(condition){
        
        case ">":
        List<int> result = new List<int>();
        for (int i = 0; i <= numbers.Count -1; i++){

            if (numbers[i] > digit){
             result.Add(numbers[i]);
            }
        }
        Console.WriteLine(string.Join(" ", result));
        break;
        case "<":
        List<int> result2 = new List<int>();
        for (int i = 0; i <= numbers.Count -1; i++){

            if (numbers[i] < digit){
             result2.Add(numbers[i]);
            }
        }
        Console.WriteLine(string.Join(" ", result2));
        break;
        case ">=":
        List<int> result3 = new List<int>();
        for (int i = 0; i <= numbers.Count -1; i++){

            if (numbers[i] >= digit){
             result3.Add(numbers[i]);
            }
        }
        Console.WriteLine(string.Join(" ", result3));
        break;
        case "<=":
        List<int> result4 = new List<int>();
        for (int i = 0; i <= numbers.Count -1; i++){

            if (numbers[i] <= digit){
             result4.Add(numbers[i]);
            }
        }
        Console.WriteLine(string.Join(" ", result4));
        break;
    }
}