using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string?> movies = new List<string?>();
        List<double> imdbRatings = new List<double>();

        while (true)
        {
            Console.WriteLine("Enter the movie name:");
            string? name = Console.ReadLine();

            Console.WriteLine("Enter the IMDb rating:");
            double rating = Convert.ToDouble(Console.ReadLine());

            movies.Add(name);
            imdbRatings.Add(rating);

            Console.WriteLine("Do you want to add another movie? (Yes/No)");
            string? answer = Console.ReadLine().ToLower();

            if (answer == "no")
                break;
        }

        // List all movies
        Console.WriteLine("\nAll Movies:");
        for (int i = 0; i < movies.Count; i++)
        {
            Console.WriteLine($"{movies[i]} - IMDb Rating: {imdbRatings[i]}");
        }

        // List all movies with IMDb rating between 4 and 9
        Console.WriteLine("\nMovies with IMDb rating between 4 and 9:");
        for (int i = 0; i < movies.Count; i++)
        {
            if (imdbRatings[i] >= 4 && imdbRatings[i] <= 9)
            {
                Console.WriteLine($"{movies[i]} - IMDb Rating: {imdbRatings[i]}");
            }
        }

        // List movies whose name starts with 'A'
        Console.WriteLine("\nMovies whose name starts with 'A':");
        for (int i = 0; i < movies.Count; i++)
        {
            if (movies[i].StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{movies[i]} - IMDb Rating: {imdbRatings[i]}");
            }
        }
    }
}