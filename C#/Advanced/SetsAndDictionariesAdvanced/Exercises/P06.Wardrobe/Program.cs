Dictionary<string, Dictionary<string,int>> colorClothes = new();

int count = int.Parse(Console.ReadLine());

for ( int i = 0; i < count; i++)
{
    string[] tokens = Console.ReadLine()
    .Split(new string[] {" -> ",","},StringSplitOptions.RemoveEmptyEntries);

    string color = tokens[0];

    if(!colorClothes.ContainsKey(color))
    {
        colorClothes.Add(color,new Dictionary<string,int>());
    }

    for (int j = 1; j < tokens.Length; j++)
    {
        string currentWear = tokens[j];

        if (!colorClothes[color].ContainsKey(currentWear))
        {
            colorClothes[color].Add(currentWear, 0);
        }

        colorClothes[color][currentWear]++;
    }
}

string[] findParams = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

foreach(var color in colorClothes)
{
    Console.WriteLine($"{color.Key} clothes:");

    foreach(var clothes in color.Value)
    {
        string printItem = $"* {clothes.Key} - {clothes.Value}";
        string findColor = findParams[0];
        string findWear = findParams[1];
        if(color.Key == findColor && clothes.Key == findWear)
        {
            printItem += " (found!)";
        }
        Console.WriteLine(printItem);
    }
}