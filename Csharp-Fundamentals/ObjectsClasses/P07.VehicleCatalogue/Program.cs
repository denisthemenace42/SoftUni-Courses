using System.Reflection;
string input;
Catalog catalog = new Catalog();

while ((input = Console.ReadLine()) != "end"){

    string[] tokens = input.Split("/").ToArray();
    string type = tokens[0];
    string brand = tokens[1];
    string model = tokens[2];

    if (type == "Truck"){

        int weight = int.Parse(tokens[3]);
        Truck truck = new Truck(brand,model,weight);
        catalog.Trucks.Add(truck);
    }
    else if (type == "Car"){

        int horsePower = int.Parse(tokens[3]);
        Car car = new Car(brand,model,horsePower);
        catalog.Cars.Add(car);
    }
}

Console.WriteLine("Cars:");
foreach (Car car in catalog.Cars.OrderBy(c => c.Brand))
{
    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
}

Console.WriteLine("Trucks:");
foreach (Truck truck in catalog.Trucks.OrderBy(t => t.Brand))
{
    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
}

public class Catalog
{
    public Catalog()
    {
        Cars = new List<Car>();
        Trucks = new List<Truck>();
    }

    public List<Car> Cars {get;set;}

    public List<Truck> Trucks {get;set;}
}

public class Truck
{
    public Truck(string brand, string model, int weight)
    {
        Brand = brand;
        Model = model;
        Weight = weight;
    }

    public string Brand {get;set;}
    public string Model {get;set;}
    public int Weight {get;set;}
    
}

public class Car
{
    public Car(string brand, string model, int horsePower)
    {
        Brand = brand;
        Model = model;
        HorsePower = horsePower;
    }

    public string Brand {get;set;}
    public string Model {get;set;}
    public int HorsePower {get;set;}
}
