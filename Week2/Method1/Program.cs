using System;

class Program
{
    // Programın çalışması için Main metodu gereklidir.
    static void Main(string[] args)
    {
        // Başlangıçta tüm  metodları çağırıyoruz.  
        PrintLyrics();
        RandomNumber();
        Console.WriteLine($"Ratgele sayının 2'ye bölümünden kalan : {RandomNumber()}");
        Multiply(5, 6);
        Console.WriteLine($"Sayıların Çarpımı: {Multiply(5, 6)}");
        GreetUser("Gına", "Getiren");
    }

    // Soru 1: Geriye değer döndürmeyen void metot.Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 
    static void PrintLyrics()
    {
        Console.WriteLine("Ne yaparsan yap, Aşk ile yap, Ne dediğin değil, nasıl dediğin olay.. Açılır kapılar ardına kadar kalpten gülersen, Kalanı detay, gerisi kolay!");
    }

    // Soru 2: Geriye tamsayı döndüren metot. Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
    public static int RandomNumber()
    {
        Random rnd = new Random(); // Rastgele sayı oluşturucu.
        int number = rnd.Next(1, 100); // 1 ile 100 arasında rastgele sayı.
        return number % 2; // Sayının 2'ye bölümünden kalan.
    }

// Soru 3: Parametre olarak aldığı iki sayının çarpımını geriye dönsün. Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
    public static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }
    // Soru 4: Parametre Alan ve Geriye Değer Döndürmeyen bir Metot. Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana basın.
    public static void GreetUser(string name, string surname)
    {
        Console.WriteLine($"Hoş Geldiniz {name} {surname}");
    } 
}
