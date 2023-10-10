int count = int.Parse(Console.ReadLine());
SortedSet<string> elements = new();

for ( int i = 0; i < count; i++)
{
    string[] inputElements = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

    elements.UnionWith(inputElements);
    
}

Console.WriteLine(string.Join(" ", elements));