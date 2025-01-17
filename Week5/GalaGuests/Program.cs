using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the names of the guests
        List<string> guests = new List<string> 
        { 
            "Bülent Ersoy", 
            "Ajda Pekkan", 
            "Ebru Gündeş", 
            "Hadise", 
            "Hande Yener", 
            "Tarkan", 
            "Funda Arar", 
            "Demet Akalın" 
        };

        // Print the names of the guests
        Console.WriteLine(" Patika Plus Gala Guests ");
        for (int i = 0; i < guests.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {guests[i]}");
        }
    }
}