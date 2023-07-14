Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

string input = Console.ReadLine();

while (input != "end")
{
    string[] inputTokens = input.Split(" : ");
    string courseName = inputTokens[0];
    string studentName = inputTokens[1];

    if (!courses.ContainsKey(courseName))
    {
        courses[courseName] = new List<string>();
    }

    courses[courseName].Add(studentName);

    input = Console.ReadLine();
}

foreach (var course in courses)
{
    Console.WriteLine($"{course.Key}: {course.Value.Count}");

    foreach (var student in course.Value)
    {
        Console.WriteLine($"-- {student}");
    }
}

