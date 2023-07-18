List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

int maxCapacity = int.Parse(Console.ReadLine());

string input;

while ((input = Console.ReadLine()) != "end"){
    
    
    string[] tokens = input.Split();      

    if (tokens[0] == "Add"){
        int extraWagon = int.Parse(tokens[1]);
        wagons.Add(extraWagon);
    }
    else {
        for (int i = 0; i<=wagons.Count-1;i++){ //30 45 23 45 0 10
           int passengers = int.Parse(tokens[0]);
           if (wagons[i]+passengers <=maxCapacity){

            wagons[i]+= passengers;
            break;
           } 
        }
    }
}
Console.WriteLine(string.Join(" ", wagons));
