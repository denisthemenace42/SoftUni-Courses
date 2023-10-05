int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

Stack<int> pieces = new Stack<int>(input);

int capacity = int.Parse(Console.ReadLine());
int racks = 1;

int atTimeValue = 0;

while (pieces.Count != 0)
{
    int currentValue = pieces.Pop();

    if (currentValue + atTimeValue > capacity)
    {
        atTimeValue = currentValue;
        racks++;
    }

    else
    {
        atTimeValue += currentValue;
    }
}

Console.WriteLine(racks);