class Program
{
    static void Main()
    {
        List<Series> seriesList = new List<Series>();
        bool continueAdding = true;

        while (continueAdding)
        {
            Series newSeries = new Series();
            
            Console.Write("Series Name: ");
            newSeries.Name = Console.ReadLine();

            Console.Write("Production Year: ");
            newSeries.ProductionYear = int.Parse(Console.ReadLine());

            Console.Write("Genre: ");
            newSeries.Genre = Console.ReadLine();

            Console.Write("Release Year: ");
            newSeries.ReleaseYear = int.Parse(Console.ReadLine());

            Console.Write("Director: ");
            newSeries.Director = Console.ReadLine();

            Console.Write("First Platform: ");
            newSeries.Platform = Console.ReadLine();

            seriesList.Add(newSeries);

            Console.Write("Would you like to add another series? (y/n): ");
            string response = Console.ReadLine().ToLower();
            continueAdding = response == "y";
        }

        // Filtering comedy series
        List<ComedySeries> comedySeriesList = seriesList
            .Where(s => s.Genre.ToLower().Contains("comedy"))
            .Select(s => new ComedySeries { Name = s.Name, Genre = s.Genre, Director = s.Director })
            .OrderBy(s => s.Name)
            .ThenBy(s => s.Director)
            .ToList();

        // Printing comedy series
        Console.WriteLine("\nComedy Series:");
        foreach (var series in comedySeriesList)
        {
            Console.WriteLine($"Series Name: {series.Name}, Genre: {series.Genre}, Director: {series.Director}");
        }
    }
}