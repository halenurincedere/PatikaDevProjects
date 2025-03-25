using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Singer> singers = new List<Singer>
        {
            new Singer { Name = "Ajda Pekkan", Genre = "Pop", DebutYear = 1968, AlbumSales = 20 },
            new Singer { Name = "Sezen Aksu", Genre = "Türk Halk Müziği / Pop", DebutYear = 1971, AlbumSales = 10 },
            new Singer { Name = "Funda Arar", Genre = "Pop", DebutYear = 1999, AlbumSales = 3 },
            new Singer { Name = "Sertab Erener", Genre = "Pop", DebutYear = 1994, AlbumSales = 5 },
            new Singer { Name = "Sıla", Genre = "Pop", DebutYear = 2009, AlbumSales = 3 },
            new Singer { Name = "Serdar Ortaç", Genre = "Pop", DebutYear = 1994, AlbumSales = 10 },
            new Singer { Name = "Tarkan", Genre = "Pop", DebutYear = 1992, AlbumSales = 40 },
            new Singer { Name = "Hande Yener", Genre = "Pop", DebutYear = 1999, AlbumSales = 7 },
            new Singer { Name = "Hadise", Genre = "Pop", DebutYear = 2005, AlbumSales = 5 },
            new Singer { Name = "Gülben Ergen", Genre = "Pop / Türk Halk Müziği", DebutYear = 1997, AlbumSales = 10 },
            new Singer { Name = "Neşet Ertaş", Genre = "Türk Halk Müziği / Türk Sanat Müziği", DebutYear = 1960, AlbumSales = 2 }
        };

        // Adı 'S' ile başlayan şarkıcılar
        var singersWithS = singers.Where(s => s.Name.StartsWith("S"));
        Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
        foreach (var singer in singersWithS) Console.WriteLine(singer.Name);
        Console.WriteLine();

        // Albüm satışları 10 milyonun üzerinde olanlar
        var highSales = singers.Where(s => s.AlbumSales > 10);
        Console.WriteLine("Albüm satışları 10 milyonun üzerinde olan şarkıcılar:");
        foreach (var singer in highSales) Console.WriteLine(singer.Name);
        Console.WriteLine();

        // 2000 yılı öncesi pop müzik yapan şarkıcılar (çıkış yılına göre gruplama ve alfabetik sıra)
        var oldPopSingers = singers.Where(s => s.DebutYear < 2000 && s.Genre.Contains("Pop"))
                                   .OrderBy(s => s.DebutYear)
                                   .ThenBy(s => s.Name);
        Console.WriteLine("2000 yılı öncesinde pop müzik yapan şarkıcılar:");
        foreach (var singer in oldPopSingers) Console.WriteLine(singer.Name);
        Console.WriteLine();

        // En çok albüm satan şarkıcı
        var bestSellingSinger = singers.OrderByDescending(s => s.AlbumSales).First();
        Console.WriteLine($"En çok albüm satan şarkıcı: {bestSellingSinger.Name}");
        Console.WriteLine();

        // En yeni ve en eski çıkış yapan şarkıcı
        var newestSinger = singers.OrderByDescending(s => s.DebutYear).First();
        var oldestSinger = singers.OrderBy(s => s.DebutYear).First();
        Console.WriteLine($"En yeni çıkış yapan şarkıcı: {newestSinger.Name}");
        Console.WriteLine($"En eski çıkış yapan şarkıcı: {oldestSinger.Name}");
    }
}