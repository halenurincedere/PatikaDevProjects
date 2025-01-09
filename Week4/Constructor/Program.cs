using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Default Constructor ile bebek oluşturma
        Baby baby1 = new Baby();
        Console.WriteLine($"Bebek Adı: {baby1.Name}, Soyadı: {baby1.Surname}, Doğum Tarihi: {baby1.BirthDate}");

        // Parametreli Constructor ile bebek oluşturma
        Baby baby2 = new Baby("Lumi", "Parlayan");
        Console.WriteLine($"Bebek Adı: {baby2.Name}, Soyadı: {baby2.Surname}, Doğum Tarihi: {baby2.BirthDate}");
    }
} 