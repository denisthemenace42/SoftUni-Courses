int studentCount = int.Parse(Console.ReadLine());

Dictionary<string,List<decimal>> student = new Dictionary<string, List<decimal>>();
for (int i = 0; i < studentCount; i++)
{
    string input = Console.ReadLine();
    string name = input.Split()[0];
    decimal grade = decimal.Parse(input.Split()[1]);

   if (!student.ContainsKey(name))
   {
    student.Add(name,new List<decimal>());
   } 
   student[name].Add(grade);
}

foreach(var entry in student)
{
    List<decimal> grades = entry.Value;
    decimal average = grades.Average();
    Console.WriteLine($"{entry.Key} -> {String.Join(" ", grades.Select(grade => $"{grade:F2}"))} (avg: {average:F2})");
}




