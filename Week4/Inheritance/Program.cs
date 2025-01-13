using System;
using BasePersonNamespace;

public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student
        {
            PersonName = "Lumi",
            PersonSurname = "Parlayan",
            StudentNumber = "123456"
        };

        // Öğretmen Nesnesi 
        Teacher teacher1 = new Teacher
        {
            PersonName = "Cemil",
            PersonSurname = "Yener",
            Salary = 100000 
        };

        student1.GetStudent();
        System.Console.WriteLine("   \n   ");
        teacher1.GetTeacher();
    }
}