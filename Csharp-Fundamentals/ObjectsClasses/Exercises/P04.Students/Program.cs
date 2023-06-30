int countOfStudents = int.Parse(Console.ReadLine());
List <Student> students = new List<Student>();

for (int i = 0; i < countOfStudents; i++){

    string[] tokens = Console.ReadLine().Split().ToArray();
    string firstName = tokens[0];
    string lastName = tokens[1];
    string grade = tokens[2];

    Student student = new Student(firstName,lastName,grade);
    students.Add(student);
}

foreach(Student student in students.OrderByDescending(x => x.Grade)){

    Console.WriteLine(student.ToString());

}

public class Student
{
    public Student(string firstName, string lastName, string grade)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        Grade = grade;
    }

    public string FirstName {get;set;}

    public string LastName {get;set;}

    public string Grade {get;set;}

    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade}";
    } 
}