Queue<string> names = new Queue<string>();

string input;
int count = 0;

while ((input = Console.ReadLine()) != "End")
{
    if (input == "Paid")
    {
        while (names.Count != 0)
        {
            Console.WriteLine(names.Dequeue());
            count--;
        }
    }

    else
    {
        names.Enqueue(input);
        count++;
    }
}

Console.WriteLine($"{count} people remaining.");