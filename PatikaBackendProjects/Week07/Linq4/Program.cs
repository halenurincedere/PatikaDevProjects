using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creating Authors List
        List<Author> authors = new List<Author>
        {
            new Author { AuthorId = 1, Name = "Orhan Pamuk" },
            new Author { AuthorId = 2, Name = "Elif Şafak" },
            new Author { AuthorId = 3, Name = "Ahmet Ümit" }
        };

        // Creating Books List
        List<Book> books = new List<Book>
        {
            new Book { BookId = 1, Title = "Kar", AuthorId = 1 },
            new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 },
            new Book { BookId = 3, Title = "10 Minutes 38 Seconds in Strange World", AuthorId = 2 },
            new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 }
        };

        // LINQ Join Query
        var bookAuthorList = from book in books
                             join author in authors on book.AuthorId equals author.AuthorId
                             select new { book.Title, author.Name };

        // Printing Results
        Console.WriteLine("Book Titles and Their Authors:\n");
        foreach (var item in bookAuthorList)
        {
            Console.WriteLine($"Book: {item.Title}, Author: {item.Name}");
        }
    }
}