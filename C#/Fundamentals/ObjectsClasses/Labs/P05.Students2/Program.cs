using System;

string input;
List<Student> students = new List<Student>();

while((input = Console.ReadLine()) != "end"){

    string[] tokens = input.Split().ToArray();
    string firstName = tokens[0];
    string lastName = tokens[1];
    int age = int.Parse(tokens[2]);
    string homeTown = tokens[3];
     
    Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
    if (student == null){

    students.Add(new Student(firstName,lastName,age,homeTown));
    }
    else {

    student.HomeTown = homeTown;
    student.Age = age;
    }
}

string outputCity = Console.ReadLine();

foreach (Student student in students){

    if (student.HomeTown == outputCity){

        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
    }
}







static bool IsStudentExisting(List<Student> students,string firstName, string lastName)
 {

    return false;
}

public class Student {
    public Student(string firstName, string lastName, int age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }

    public string FirstName { get;set;}
    public string LastName {get;set;}
    public int  Age {get;set;}
    public string HomeTown {get;set;}
}
