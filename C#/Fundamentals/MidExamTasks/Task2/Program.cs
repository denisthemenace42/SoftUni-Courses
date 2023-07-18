List<string> coffees = Console.ReadLine().Split().ToList();

int countCommands = int.Parse(Console.ReadLine());
string input;
for ( int i = 0; i < countCommands; i++){

  input = Console.ReadLine();
  string[] tokens = input.Split();

  switch (tokens[0]){

    case "Include":
    string addCoffee = tokens[1];
    coffees.Add(addCoffee);
    break;

    case "Remove":
    int numberOfCoffees = int.Parse(tokens[2]);
    string removeType = tokens[1];
   
    if (removeType == "first" && numberOfCoffees >= 0 && numberOfCoffees<coffees.Count){

     coffees.RemoveRange(0,numberOfCoffees);
    }
    if (removeType == "last" && numberOfCoffees >= 0 && numberOfCoffees<coffees.Count){

     coffees.RemoveRange(coffees.Count-numberOfCoffees,numberOfCoffees);
    }
    break;

    case "Prefer":
    int coffeeIndex1 = int.Parse(tokens[1]);
    int coffeeIndex2 = int.Parse(tokens[2]);

    if (coffeeIndex1 >= 0 && coffeeIndex1 < coffees.Count && coffeeIndex2 >= 0 && coffeeIndex2 < coffees.Count){
    
    string temp = coffees[coffeeIndex1];
     coffees[coffeeIndex1] = coffees[coffeeIndex2];
     coffees[coffeeIndex2] = temp;
    }
    break;

    case "Reverse":
    coffees.Reverse();
    break;
  }    
}
Console.WriteLine("Coffees:");
Console.WriteLine(string.Join(" ",coffees));