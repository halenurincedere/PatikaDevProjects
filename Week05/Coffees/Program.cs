using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an empty list.
        List<string> coffees = new List<string>();

        // Get 5 coffee names from the user and add them to the list.
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Enter the name of coffee {i}:");
            string? coffee = Console.ReadLine();
            coffees.Add(coffee);
        }

        // Print the list using a foreach loop.
        Console.WriteLine("\nThe coffees you entered:");
        foreach (var coffee in coffees)
        {
            Console.WriteLine(coffee);
        }
    }
}