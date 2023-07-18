int commandsCount = int.Parse(Console.ReadLine());
List<string> guests = new List<string>();
for (int i = 0; i < commandsCount; i ++){

   string input = Console.ReadLine();
   string[] tokens = input.Split();
   string name = tokens[0];
  switch(tokens[2]){

    case "going!":
    if (guests.Contains(name)){
      
      Console.WriteLine($"{name} is already in the list!");
    }
    else {

        guests.Add(name);
    }
    break;
    case "not":
    if (guests.Contains(name)){
      
      guests.Remove(name);
      
    }
    else {

        Console.WriteLine($"{name} is not in the list!");
    }
    break;
  }
}
foreach(string names in guests){

Console.WriteLine(names);
}
