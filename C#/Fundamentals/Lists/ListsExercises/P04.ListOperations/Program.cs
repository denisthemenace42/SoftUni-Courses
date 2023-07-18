using System.Globalization;
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input;

while ((input = Console.ReadLine()) != "End"){

    string[] tokens = input.Split();

    switch(tokens[0]){

        case "Add":
        int addNumber = int.Parse(tokens[1]);
        numbers.Add(addNumber);
        break;
        case "Insert":
        int insertNumber = int.Parse(tokens[1]);
        int index = int.Parse(tokens[2]);
        if (index > numbers.Count || index < 0){
            Console.WriteLine("Invalid index");
        }
        else {

             numbers.Insert(index,insertNumber);
        }
        break;
        case "Remove":
        int removeAt = int.Parse(tokens[1]);
        if (removeAt > numbers.Count || removeAt < 0){
            Console.WriteLine("Invalid index");
        }
        else {

            numbers.RemoveAt(removeAt);
        }
        break;
        case "Shift":
        string direction = tokens[1];
        int count = int.Parse(tokens[2]);
        if (direction == "left"){

         while (count != 0){
            int currentDigit = numbers[0];
            numbers.RemoveAt(0);
            numbers.Add(currentDigit);
            count--;
         }
        }
        else {

            while (count != 0){

           int currentDigit = numbers[numbers.Count-1];
           numbers.RemoveAt(numbers.Count-1);
           numbers.Insert(0,currentDigit);
           count--;
            }

        }
        break;
        
    }
}

Console.WriteLine(string.Join(" ", numbers));