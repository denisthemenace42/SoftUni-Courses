Queue<int> numbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
List<int> evenNumbers = new List<int>();
while (numbers.Count != 0)
{
    int currentNumber = numbers.Dequeue();
    if (currentNumber % 2 == 0)
    {
        evenNumbers.Add(currentNumber);
    }

}
Console.WriteLine(string.Join(", ", evenNumbers));

