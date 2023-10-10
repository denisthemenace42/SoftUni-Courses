using System.ComponentModel;

int count = int.Parse(Console.ReadLine());
HashSet<string> usernames = new HashSet<string>();

for (int i = 0; i < count; i++)
{
    string username = Console.ReadLine();

    usernames.Add(username);
}

foreach(string name in usernames)
{
    Console.WriteLine(name);
}