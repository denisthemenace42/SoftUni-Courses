int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int valuesToPush = values[0];
int valuesToPop = values[1];
int lookUpValue = values[2];

Queue<int> numbers = new Queue<int>(input.Take(valuesToPush));


while (numbers.Count != 0 && valuesToPop > 0)
{
    numbers.Dequeue();
    valuesToPop--;
}

if (numbers.Contains(lookUpValue))
{
    Console.WriteLine("true");
}

else if (numbers.Count == 0)
{
    Console.WriteLine(0);
}

else
{
    Console.WriteLine(numbers.Min());
}


