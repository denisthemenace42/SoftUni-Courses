List<double> numbers = Console.ReadLine()
.Split(" ",StringSplitOptions.RemoveEmptyEntries)
.Select(double.Parse)
.ToList();

Dictionary<double, int> countNumbers = new Dictionary<double, int>();

foreach(double number in numbers)
{
    if (!countNumbers.ContainsKey(number))
    {
        countNumbers.Add(number,1);
    }
    else
    {
        countNumbers[number]++;
    }
}

foreach(var entry in countNumbers)
{
    Console.WriteLine($"{entry.Key} - {entry.Value} times");
}



