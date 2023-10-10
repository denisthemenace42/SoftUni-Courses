string input = Console.ReadLine();

HashSet<string> guests = new();
HashSet<string> vipGuests = new();

while(input != "PARTY")
{
    if (char.IsDigit(input[0]))
    {
        vipGuests.Add(input);
    }
    else
    {
        guests.Add(input);
    }
    input = Console.ReadLine();
}


while (input != "END")
{
    guests.Remove(input);
    vipGuests.Remove(input);
    input = Console.ReadLine();
}

Console.WriteLine(vipGuests.Count+guests.Count);
foreach(var vipGuest in vipGuests)
{
    Console.WriteLine(vipGuest);
}

foreach(var guest in guests)
{
    Console.WriteLine(guest);
}

