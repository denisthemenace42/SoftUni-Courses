using System.IO;
using System.Text.RegularExpressions;
string input;

List<Customer> customers = new List<Customer>();
decimal totalPrice = 0;
while ((input = Console.ReadLine()) != "end of shift")
{

    string pattern = @"%(?<name>[A-Z][a-z]+)%[^|'$%.]*<(?<item>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";

    Regex r = new Regex(pattern);
    MatchCollection collection = r.Matches(input);

    foreach (Match match in collection)
    {
        string customerName = match.Groups["name"].Value;
        string customerItem = match.Groups["item"].Value;
        int quantity = int.Parse(match.Groups["quantity"].Value);
        decimal price = decimal.Parse(match.Groups["price"].Value);

        Customer customer = new Customer(customerName, customerItem, price, quantity);
        customers.Add(customer);

        totalPrice += customer.Total();
        Console.WriteLine($"{customerName}: {customerItem} - {customer.Total():f2}");
    }

}

Console.WriteLine($"Total income: {totalPrice:f2}");


public class Customer
{
    public Customer(string name, string item, decimal price, int quantity)
    {
        Name = name;
        Item = Item;
        Price = price;
        Quantity = quantity;
    }

    public string Name { get; set; }

    public string Item { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public decimal Total()
    {
        return Price * Quantity;
    }

}