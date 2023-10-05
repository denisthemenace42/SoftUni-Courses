using System.Collections.Concurrent;
using System.Xml;
using System.Globalization;
int foodQuantity = int.Parse(Console.ReadLine());

Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

Console.WriteLine(orders.Max());
while(orders.Count != 0)
{

    if (foodQuantity  != 0)
    {
        int currentNumber = orders.Dequeue();
    foodQuantity -= currentNumber;
        Console.WriteLine("Orders complete");
        break;
    }

}

Console.WriteLine(String.Join(", ", orders));



