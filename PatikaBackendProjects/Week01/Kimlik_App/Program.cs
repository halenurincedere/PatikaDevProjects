using System;
using System.Drawing;

namespace Kimlik_App
{
    class Program
    {
        static void Main(string[] args)

        //Kullanıcıya T.C Kimlik Numarasını, adını, soyadını , telefon numarasını, yaşını, ilk aldığı ürünün fiyatını, ikinci aldığını ürünün fiyatını soran ve bu değerleri kullanıcıdan sırasıyla alan bir uygulama kodlayınız. Uygulama girilen ürün fiyatına göre aşağıdaki gibi bir mesaj yayınlasın.Ek : Telefon Numarası ve Son aldığı ürün fiyatı verilerini saklamak için hangi veri tiplerini kullandığınızı nedeniyle yorum satırı olarak ekleyiniz.

        { 
            // Önce değerleri tanımlamak istedim.
            
            string? tc, name, surnume, phone; // Telefon numarası string olarak tanımlandı çünkü telefon numarası sayısal bir işlem olmadığı için.
            int? age, product1, product2, total; // Yaş ve ürün fiyatları sayısal bir değer olduğu için int olarak tanımlandı.
            Console.WriteLine("----------- PATİKA DEV C#101 ÖDEV 1 -----------");

            Console.Write("Lütfen T.C Kimlik Numaranızı Giriniz:");
            tc = Console.ReadLine();

            Console.Write("Lütfsen Adınızı Giriniz:");
            name = Console.ReadLine();

            Console.Write("Lütfen Soyadınızı Giriniz:");
            surnume = Console.ReadLine();

            Console.Write("Lütfen Telefon Numaranızı Giriniz:");
            phone = Console.ReadLine();

            Console.Write("Lütfen Yaşınızı Giriniz:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen İlk Aldığınız Ürünün Fiyatını Giriniz:");
            product1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen İkinci Aldığınız Ürünün Fiyatını Giriniz:");
            product2 = Convert.ToInt32(Console.ReadLine());

            total = product1 + product2;
            double? point = total * 0.10;


            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"{tc} T.C kimlik numaralı  {name}, {surnume} adlı kişi için kayıt oluşturulmuştur. \n {phone} telefon numarasına bildirim mesajı gönderilmiştir. \n {total} toplam harcama karşılığında kazanılan Patika puan miktarı -> {point} ₺'dir");
        }
    }
}