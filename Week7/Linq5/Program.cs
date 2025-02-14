using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Define class list
        List<Class> classes = new List<Class>
        {
            new Class { ClassId = 1, ClassName = "Matematik" },
            new Class { ClassId = 2, ClassName = "Türkçe" },
            new Class { ClassId = 3, ClassName = "Kimya" }
        };

        // Define student list
        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
            new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
            new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
            new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 },
            new Student { StudentId = 5, StudentName = "Ahmet", ClassId = 2 }
        };

        // LINQ Group Join
        var result = from cls in classes
                     join std in students on cls.ClassId equals std.ClassId into studentGroup
                     select new
                     {
                         ClassName = cls.ClassName,
                         Students = studentGroup
                     };

        // Display results
        foreach (var item in result)
        {
            Console.WriteLine($"Class: {item.ClassName}");
            foreach (var student in item.Students)
            {
                Console.WriteLine($"  - {student.StudentName}");
            }
            Console.WriteLine();
        }
    }
}

// Define Student class
class Student
{
    public int StudentId { get; set; }
    public string? StudentName { get; set; }
    public int ClassId { get; set; }
}

// Define Class class
class Class
{
    public int ClassId { get; set; }
    public string? ClassName { get; set; }
}
