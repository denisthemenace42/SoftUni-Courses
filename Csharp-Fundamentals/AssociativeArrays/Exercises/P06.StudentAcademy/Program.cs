int commandCount = int.Parse(Console.ReadLine());

Dictionary<string,List<double>> academy = new Dictionary<string,List<double>>();

for (int i = 0; i < commandCount; i ++){

    string studentName = Console.ReadLine();
    double studentGrade = double.Parse(Console.ReadLine());

    if(!academy.ContainsKey(studentName)){

        academy[studentName] = new List<double>(); 
    }

    academy[studentName].Add(studentGrade);
}

var filteredStudents = academy
    .Where(x => x.Value.Average() >= 4.50);

foreach(var student in filteredStudents){

    string name = student.Key;
    double avgGrade = student.Value.Average();

    Console.WriteLine($"{name} -> {avgGrade:f2}");

}