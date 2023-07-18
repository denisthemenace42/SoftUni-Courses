using System.Linq.Expressions;
string input;

Dictionary<string,Product> products = new Dictionary<string, Product>();
while ((input = Console.ReadLine()) != "buy"){

    string[] tokens = input.Split().ToArray();
    string productName = tokens[0];
    decimal productPrice = decimal.Parse(tokens[1]);
    decimal productQuantity = decimal.Parse(tokens[2]);

    Product product = new Product(productName,productPrice,productQuantity);

     if (!products.ContainsKey(product.Name)){

        products.Add(product.Name,product);
    }
    else {

        products[product.Name].Update(product.Price,product.Quantity);
    }

}

foreach(KeyValuePair<string,Product>pair in products){

    Console.WriteLine(pair.Value);
}


public class Product
{
    public Product(string name, decimal price, decimal quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public string Name {get; set;}

    public decimal Price {get; set;}

    public decimal Quantity {get; set;}

    public void Update(decimal price, decimal quantity)
    {
       Price = price;
       Quantity += quantity;
    }

    public override string ToString()
    {
        return $"{Name} -> {Price * Quantity}";
    }
}