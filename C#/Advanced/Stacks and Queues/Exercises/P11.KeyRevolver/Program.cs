int bulletPrice = int.Parse(Console.ReadLine());
int gunBarrelSize = int.Parse(Console.ReadLine());
int[] inputBullets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Stack<int> bullets = new Stack<int>(inputBullets);
int[] inputLocks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Queue<int> locks = new Queue<int>(inputLocks);
int valueOfIntelligence = int.Parse(Console.ReadLine());

int currentBarrel = gunBarrelSize;
int bulletsCount = 0;

while (bullets.Count > 0 && locks.Count > 0)
{
    int currentBullet = bullets.Pop();
    int currentLock = locks.Peek();
    bulletsCount++;

    if (currentBullet <= currentLock)
    {
        Console.WriteLine("Bang!");
        locks.Dequeue();
    }

    else
    {
        Console.WriteLine("Ping!");
    }

    currentBarrel--;

    if (currentBarrel == 0 && bullets.Count > 0)
    {
        Console.WriteLine("Reloading!");
        currentBarrel = gunBarrelSize;
    }
}

if (bullets.Count == 0 && locks.Count > 0)
{
    int locksLeft = locks.Count;
    Console.WriteLine($"Couldn't get through. Locks left: {locksLeft}");
}
else
{
    int bulletsLeft = bullets.Count;
    int moneyEarned = valueOfIntelligence - (bulletsCount * bulletPrice);
    Console.WriteLine($"{bulletsLeft} bullets left. Earned ${moneyEarned}");
    return;
}


