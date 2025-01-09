public class Book
{
    // Properties
    public string BookName { get; set; }
    public string AuthorName { get; set; } 
    public string AuthorSurname { get; set; }
    public int PageCount { get; set; } 
    public string Publisher { get; set; } 
    public DateTime RegistrationDate { get; set; }

    // Default Constructor
    public Book()
    {
        BookName = "Bilinmiyor"; 
        AuthorName = "Bilinmiyor";
        AuthorSurname = "Bilinmiyor";
        PageCount = 0;
        Publisher = "Bilinmiyor";
        RegistrationDate = DateTime.Now;
        Console.WriteLine("Kitap kaydedildi! (Default Constructor)");
    }

    // Parameterized Constructor
    public Book(string title, string authorName, string authorSurname, int pageCount, string publisher)
    {
        BookName = title; 
        AuthorName = authorName;
        AuthorSurname = authorSurname; 
        PageCount = pageCount;
        Publisher = publisher;
        RegistrationDate = DateTime.Now;
        Console.WriteLine("Kitap kaydedildi! (Parametreli Constructor)");
    }

      // Method
    public void DisplayBookInfo()
    {
        Console.WriteLine($"Kitap Adı: {BookName}, Yazar: {AuthorName} {AuthorSurname}, Sayfa Sayısı: {PageCount}, Yayınevi: {Publisher}, Kayıt Tarihi: {RegistrationDate}");
    }
}