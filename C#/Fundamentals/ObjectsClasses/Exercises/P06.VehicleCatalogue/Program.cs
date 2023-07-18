using System.Linq;
string input;
List<Vehicle> vehicles = new List<Vehicle>();
while ((input = Console.ReadLine()) != "End"){

    string[] tokens = input.Split().ToArray();

    string type = tokens[0];
    string model = tokens[1];
    string color = tokens[2];
    int horsePower = int.Parse(tokens[3]);

   Vehicle vehicle = new Vehicle(type,model,color,horsePower);
   vehicles.Add(vehicle);

}

int carCount = vehicles.Count(x => x.Type == "car");
int truckCount = vehicles.Count(x =>x.Type == "truck");

double carAvgHorsepower = carCount > 0 ? vehicles.Where(x => x.Type == "car").Average(x => x.HorsePower): 0.0;
double truckAvgHorsepower = truckCount > 0 ? vehicles.Where(x => x.Type == "truck").Average(x => x.HorsePower): 0.0;

while ((input = Console.ReadLine()) != "Close the Catalogue"){

    Vehicle vehicle = vehicles.FirstOrDefault(x => x.Model == input);

    if (vehicle != null){

        Console.WriteLine($"Type: {vehicle.Type.First().ToString().ToUpper() + vehicle.Type.Substring(1)}");
        Console.WriteLine($"Model: {vehicle.Model}");
        Console.WriteLine($"Color: {vehicle.Color}");
        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
    }    
}

Console.WriteLine(carCount > 0 ? $"Cars have average horsepower of: {carAvgHorsepower:f2}.":$"Cars have average horsepower of: {0:f2}." );
Console.WriteLine(truckCount > 0 ? $"Trucks have average horsepower of: {truckAvgHorsepower:f2}.":$"Trucks have average horsepower of: {0:f2}.");



public class Vehicle
{
    public Vehicle(string type, string model, string color, int horsePower)
    {
        Type = type;
        Model = model;
        Color = color;
        HorsePower = horsePower;
    }

    public string Type {get;set;}
    public string Model {get;set;}

    public string Color {get;set;}
    public int HorsePower {get;set;}
}