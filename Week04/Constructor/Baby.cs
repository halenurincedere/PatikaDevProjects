public class Baby
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }

    // Default Constructor
    public Baby()
    {
        Name = "Bilinmiyor";
        Surname = "Bilinmiyor";
        BirthDate = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }

    // Parametreli Constructor
    public Baby(string name, string surname)
    {
        Name = name;
        Surname = surname;
        BirthDate = DateTime.Now;
        Console.WriteLine(" \nIngaaaa");
    }
}
