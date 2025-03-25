using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Student 1
        Person student1 = new Person();
        student1.Name = "Halenur";
        student1.Surname = "İncedere";
        student1.BirthDate = new DateTime(1999, 8, 18);

        // Student 2
        Person student2 = new Person();
        student2.Name = "Can";
        student2.Surname = "Kutlu";
        student2.BirthDate = new DateTime(1996, 4, 17);

        // Teacher 1
        Person teacher1 = new Person();
        teacher1.Name = "Koray";
        teacher1.Surname = "Adıvar";
        teacher1.BirthDate = new DateTime(1989, 2, 28);

        // Teacher 2
        Person teacher2 = new Person();
        teacher2.Name = "Ayşe";
        teacher2.Surname = "Yılmaz";
        teacher2.BirthDate = new DateTime(1985, 3, 12);

        // Printing information
        Console.WriteLine("Students:");
        student1.DisplayPerson();
        student2.DisplayPerson();

        Console.WriteLine("\nTeachers:");
        teacher1.DisplayPerson();
        teacher2.DisplayPerson();
    }
}