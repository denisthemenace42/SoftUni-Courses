int count = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, string>> map = new Dictionary<string, Dictionary<string, string>>();

for (int i = 0; i < count; i++)
{
    string input = Console.ReadLine();
    string[] parts = input.Split(" ");

    if (parts.Length == 3)
    {
        string continent = parts[0];
        string country = parts[1];
        string cities = parts[2];

        if (!map.ContainsKey(continent))
        {
            map.Add(continent, new Dictionary<string, string>());
        }

        if (!map[continent].ContainsKey(country))
        {
            map[continent].Add(country, cities);
        }
        else
        {
            map[continent][country] += $", {cities}";
        }
    }
}

foreach (var continent in map)
{
    Console.WriteLine($"{continent.Key}:");

    foreach (var country in continent.Value)
    {
        Console.WriteLine($"{country.Key} -> {country.Value}");
    }
}
