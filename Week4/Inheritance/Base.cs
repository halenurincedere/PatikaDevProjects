using System;

namespace BasePersonNamespace
{
public class BasePerson
{
    public string? PersonName { get; set; }
    public string? PersonSurname { get; set; }

    public void GetBasePerson()
    {
        Console.WriteLine($"Name : {PersonName}\nSurname: { PersonSurname}");
    }
}

//--------------------------------------------------------------------------------------------------------------------

public class Student : BasePerson
{
    public string? StudentNumber { get; set; }

    public void GetStudent()
    {
        Console.WriteLine("------------STUDENT-----------");
        GetBasePerson();
        Console.WriteLine($"Student Number: {StudentNumber} ");
    }
}

//--------------------------------------------------------------------------------------------------------------------
public class Teacher : BasePerson
    {
    public int Salary { get; set; }
        public void GetTeacher()
        {
            Console.WriteLine("------------TEACHER-----------");
            GetBasePerson();
            Console.WriteLine($"Salary: {Salary} ");
        }
    }
}