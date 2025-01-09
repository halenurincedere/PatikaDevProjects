using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Default Constructor
        Book book1 = new Book();
        book1.DisplayBookInfo();

        // Parameterized Constructor
        Book book2 = new Book("Kimlik", "Milen", "Kundera", 136, "Can Yayınları");
        book2.DisplayBookInfo();

        // Class : Nesneyi oluşturur. İçinde nesneye ait özellikler ve davranışlar bulundurur.📦

        // Property : Sınıfın, özelliklerini içinde tutan yapıdır. 

        // New : Anahtar kelimedir. Yeni bir nesne oluşturmak için kullanılır.🔑

        // Constructor:Bir sınıftan nesne oluşturulurken otomatik olarak çalışan özel bir metottur.Özelliklere başlangıç değerleri atanır.Bir sınıfta en az bir constructor olmak zorundadır.Paremetreli, paremetresiz iki yapı bulunur.  Constructor tanımlanırken sınıf adı ile aynı isme sahip olmalıdır. Geri dönüş türü (return type) belirtilmez ve void dahi kullanılmaz.⚠️
    }
}