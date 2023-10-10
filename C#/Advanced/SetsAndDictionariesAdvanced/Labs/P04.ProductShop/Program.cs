string command = Console.ReadLine();

Dictionary<string,Dictionary<string,double>> markets = new Dictionary<string, Dictionary<string, double>>();

while (command != "Revision")
{
    string[] tokens = command.Split(", ");
    string shop = tokens[0];
    string product = tokens[1];
    double price = double.Parse(tokens[2]);

    if (!markets.ContainsKey(shop))
    {
        markets.Add(shop, new Dictionary<string, double>());
    }

    markets[shop].Add(product,price);

    command = Console.ReadLine();
}

foreach(var shop in markets.OrderBy(x => x.Key))
{
    string name = shop.Key;
    Console.WriteLine($"{name}->");

    foreach(var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
    
}
