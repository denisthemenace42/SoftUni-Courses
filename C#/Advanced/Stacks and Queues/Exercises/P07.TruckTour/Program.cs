int totalPumps = int.Parse(Console.ReadLine());

Queue<(int,int)> pumps = new Queue<(int, int)>();

for (int i = 0; i < totalPumps; i++)
{
    int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();

    int petrol = tokens[0];
    int distance = tokens[1];

    pumps.Enqueue((petrol,distance));
}

int bestRoute = 0;

while (true)
{
    int totalPetrol = 0;

    foreach((int,int) pump in pumps)
    {
        totalPetrol += pump.Item1;
        int currentDistance = pump.Item2;

        if (totalPetrol - currentDistance < 0)
        {
            totalPetrol = 0;
            break;
        }
        else 
        {
            totalPetrol -= currentDistance;
        }
    }

    if (totalPetrol > 0)
    {
        break;
    }

    bestRoute++;
    pumps.Enqueue(pumps.Dequeue());
}

Console.WriteLine(bestRoute);