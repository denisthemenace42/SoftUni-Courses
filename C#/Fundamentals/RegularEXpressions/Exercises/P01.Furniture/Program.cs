using System.Text.RegularExpressions;
string input = string.Empty;
string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+|\d+\.\d+)!(?<quantity>\d+)";

List<Item> furnitures = new List<Item>();

while ((input = Console.ReadLine()) != "Purchase")
{
    Regex r = new Regex(pattern);
    MatchCollection collection = r.Matches(input);

    foreach (Match match in collection)
    {
        string name = match.Groups["name"].Value;
        decimal price = decimal.Parse(match.Groups["price"].Value);
        int quantity = int.Parse(match.Groups["quantity"].Value);

        Item item = new Item(name, price, quantity);
        furnitures.Add(item);
    }
}

Console.WriteLine($"Bought furniture:");
decimal totalSpend = 0m;

foreach (Item furniture in furnitures)
{
    Console.WriteLine(furniture.Name);
    totalSpend += furniture.Total();

}

Console.WriteLine($"Total money spend: {totalSpend:f2}");


public class Item
{
    public Item(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public decimal Total()
    {
        return Price * Quantity;
    }

}