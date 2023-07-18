Dictionary<string, List<string>> database = new Dictionary<string, List<string>>();

string input = Console.ReadLine();

while (input != "End")
{
    string[] inputTokens = input.Split(" -> ");
    string companyName = inputTokens[0];
    string employeeId = inputTokens[1];

    if (!database.ContainsKey(companyName))
    {
        database[companyName] = new List<string>();
    }

    if (!database[companyName].Contains(employeeId))
    {
        database[companyName].Add(employeeId);
    }

    input = Console.ReadLine();
}

foreach (var company in database)
{
    Console.WriteLine(company.Key);

    foreach (var employeeId in company.Value)
    {
        Console.WriteLine($"-- {employeeId}");
    }
}

