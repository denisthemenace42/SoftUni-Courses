using System.Linq;
string input;

List<People> people = new List<People>();
while ((input = Console.ReadLine()) != "End"){

    string[] tokens = input.Split().ToArray();
    string name = tokens[0];
    string id = tokens[1];
    int age = int.Parse(tokens[2]);

    var existingPerson = people.FirstOrDefault(x => x.Id == id);

    if (existingPerson != null){

        existingPerson.Name = name;
        existingPerson.Age = age;
        continue;
    }

    People individual = new People(name,id,age);
    people.Add(individual);
}

foreach(People person in people.OrderBy(x => x.Age)){

     Console.WriteLine(person.ToString());
}

public class People 
{
    public People(string name, string id, int age)
    {
        Name = name;
        Id = id;
        Age = age;
    }

    public string Name {get;set;}

    public string Id {get;set;}

    public int Age {get;set;}

    public override string ToString()
    {
        return $"{Name} with ID: {Id} is {Age} years old.";
    }
}