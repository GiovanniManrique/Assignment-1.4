using System;

class Student
{
    public int StudentId { get; set; }
    public string StudentFname { get; set; }
    public string StudentLname { get; set; }
    public char StudentGrade { get; set; }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();

        student1.StudentId = 1;
        student1.StudentFname = "Giovanni";
        student1.StudentLname = "Ruiz";
        student1.StudentGrade = 'A';

        Console.WriteLine("Student ID: " + student1.StudentId);
        Console.WriteLine("First Name: " + student1.StudentFname);
        Console.WriteLine("Last Name: " + student1.StudentLname);
        Console.WriteLine("Grade: " + student1.StudentGrade);
    }
}