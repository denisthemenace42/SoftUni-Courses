int carCount = int.Parse(Console.ReadLine());

Queue<string> cars = new Queue<string>();

int passedCarsCount = 0;

string input;

while ((input = Console.ReadLine()) != "end")
{
    if (input == "green")
    {
        for (int i = 0; i < carCount; i++)
        {
            if (cars.Count == 0)
            {
                break;
            }
            Console.WriteLine($"{cars.Dequeue()} passed!");
            passedCarsCount++;
        }

    }
    else
    {
        cars.Enqueue(input);
    }
    
}

Console.WriteLine($"{passedCarsCount} cars passed the crossroads.");