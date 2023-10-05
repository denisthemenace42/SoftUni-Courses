using System.Collections.Concurrent;
using System.Xml;
using System.Globalization;

int foodQuantity = int.Parse(Console.ReadLine());

Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

Console.WriteLine(orders.Max());
while(orders.Count != 0)
{
    if (orders.Peek() > foodQuantity)
    {
        break;
    }

    foodQuantity -= orders.Dequeue();
  
}

Console.WriteLine(orders.Count == 0 ? "Orders complete" : $"Orders left: {String.Join(" ", orders)}");






