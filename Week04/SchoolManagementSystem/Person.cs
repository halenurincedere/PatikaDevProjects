public class Person
{
    public string? Name { get; set ; } // Hides name
    public string? Surname { get; set; } // Hides surname
    public DateTime BirthDate { get; set; } // Hides bithdate

    // A method that prints person information
    public void DisplayPerson()
    {
        Console.WriteLine($"Ad: {Name}, Soyad: {Surname}, Doğum Tarihi: {BirthDate.ToLongDateString()}");
    }
}