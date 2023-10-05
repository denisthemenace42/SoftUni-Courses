int greenLightSeconds = int.Parse(Console.ReadLine());

int freeWindowSeconds = int.Parse(Console.ReadLine());

int totalCarsPassed = 0;

string input = string.Empty;

Queue<string> cars = new Queue<string>();

while ((input = Console.ReadLine()) != "END")
{

    if (input != "green")
    {
        cars.Enqueue(input);
        continue;
    }

    int currentLightSeconds = greenLightSeconds;

    while (cars.Count > 0 && currentLightSeconds > 0)
    {
        string car = cars.Dequeue();

        if (currentLightSeconds - car.Length >= 0)
        {
            currentLightSeconds -= car.Length;
            totalCarsPassed++;
            continue;
        }

        else if (currentLightSeconds + freeWindowSeconds - car.Length >= 0)
        {
            totalCarsPassed++;
            break;
        }

        else
        {
            char characterHit = car[currentLightSeconds + freeWindowSeconds];
            Console.WriteLine("A crash happened!");
            Console.WriteLine($"{car} was hit at {characterHit}.");
            return;
        }
    }
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");







