string input;

List<Animal> animals = new List<Animal>();

while ((input = Console.ReadLine()) != "EndDay")
{
    string[] commands = input.Split(":");
    string[] tokens = commands[1].Split("-", System.StringSplitOptions.RemoveEmptyEntries);

    if (commands[0] == "Add")
    {

        string animalName = tokens[0];
        int quantity = int.Parse(tokens[1]);
        string location = tokens[2];

        Animal existingAnimal = animals.Find(a => a.Name == animalName && a.Location == location);
        if (existingAnimal != null)
        {
            existingAnimal.Quantity += quantity;
        }
        else
        {
            Animal animal = new Animal(animalName, quantity, location);
            animals.Add(animal);
        }

    }

    else if (commands[0] == "Feed")
    {
        string animalName = tokens[0];
        int quantity = int.Parse(tokens[1]);

        Animal existingAnimal = animals.Find(a => a.Name == animalName);
        if (existingAnimal != null)
        {

            existingAnimal.Quantity -= quantity;


            if (existingAnimal.Quantity <= 0)
            {
                animals.Remove(existingAnimal);
                Console.WriteLine($"{animalName} was successfully fed");
            }

        }
    }

}

Console.WriteLine("Animals:");
foreach (var animal in animals)
{
    Console.WriteLine($" {animal.Name} -> {animal.Quantity}g");
}

Console.WriteLine("Areas with hungry animals:");
var hungryAnimalsByLocation = new Dictionary<string, int>();
foreach (var animal in animals)
{
    if (!hungryAnimalsByLocation.ContainsKey(animal.Location))
    {
        hungryAnimalsByLocation[animal.Location] = 0;
    }
    hungryAnimalsByLocation[animal.Location]++;
}

foreach (var animal in hungryAnimalsByLocation)
{
    Console.WriteLine($" {animal.Key}: {animal.Value}");
}

public class Animal
{
    public Animal(string name, int quantity, string location)
    {
        Name = name;
        Quantity = quantity;
        Location = location;
    }

    public string Name { get; set; }

    public int Quantity { get; set; }

    public string Location { get; set; }
}