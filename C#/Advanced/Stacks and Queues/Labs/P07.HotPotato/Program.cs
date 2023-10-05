Queue<string> childrens = new Queue<string>(Console.ReadLine().Split());

int tossCount = int.Parse(Console.ReadLine());

int tosses = 0;

while (childrens.Count > 1)
{
    tosses++;
    string childWithPotato = childrens.Dequeue();

    if (tosses == tossCount)
    {
        tosses = 0;
        Console.WriteLine($"Removed {childWithPotato}");
    }
    else
    {
        childrens.Enqueue(childWithPotato);
    }
}

Console.WriteLine($"Last is {childrens.Dequeue()}");

