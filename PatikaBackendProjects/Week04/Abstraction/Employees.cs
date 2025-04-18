using System;

// Abstract Class
public abstract class BaseEmployee
{
    // Common properties
    public string? EmployeeName { get; set; }
    public string? EmployeeSurname { get; set; }
    public string? Department { get; set; }

    // Common behavior
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Name: {EmployeeName}, Surname: {EmployeeSurname}, Department: {Department}");
    }

    // Abstract method to be implemented by derived classes
    public abstract void PerformDuty();
}

// Derived class: Project Manager
public class ProjectManager : BaseEmployee
{
    public override void PerformDuty()
    {
        Console.WriteLine("I am working as a project manager.");
    }
}

// Derived class: Software Developer
public class SoftwareDeveloper : BaseEmployee
{
    public override void PerformDuty()
    {
        Console.WriteLine("I am working as a data security software developer.");
    }
}