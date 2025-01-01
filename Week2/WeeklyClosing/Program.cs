class Program
{
    static void Main(string[] args)
    {
        // Soru 1: Ekrana Merhaba, Nasılsın ? İyiyim , Sen nasılsın ? yazdırın.
        Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");
        
        // Soru 2: Bir adet metinsel, bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp, ekrana yazdırınız.
        string metin = "Merhaba";
        int sayi = 5;
        Console.WriteLine(metin + " " + sayi);

        // Soru 3: Rastgele bir sayı üretip, ekrana yazdırınız.
        Random rnd = new Random();
        int rastgeleSayi = rnd.Next(1, 100);
        Console.WriteLine($"Rastgele sayı: {rastgeleSayi}");

        // Soru 4: Rastgele bir sayı üretip, bunun 3'e bölümünden kalanı ekrana yazdırınız.
        int rastgeleSayi2 = rnd.Next(1, 100);
        int kalan = rastgeleSayi2 % 3;
        Console.WriteLine($"Rastgele sayı: {rastgeleSayi2}, 3'e bölümünden kalan: {kalan}");

        // Soru 5: Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
        Console.Write("Yaşınızı giriniz: ");
        int yas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(yas >= 18 ? "+" : "-");

        // Soru 6: Ekrana 10 defa bir mesaj yazan bir uygulama.
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
        }

        // Soru 7: Kullanıcıdan iki metin alıp yerlerini değiştiriniz.
        Console.Write("İlk metni giriniz: ");
        string metin1 = Console.ReadLine();
        Console.Write("İkinci metni giriniz: ");
        string metin2 = Console.ReadLine();

        string gecici = metin1;
        metin1 = metin2;
        metin2 = gecici;

        Console.WriteLine($"{metin1}, {metin2}");

        // Soru 8: Kullanıcıdan iki isim alıp yerlerini değiştiriniz.
        Console.Write("İsim 1: ");
        string? isim1 = Console.ReadLine();
        Console.Write("İsim 2: ");
        string? isim2 = Console.ReadLine();

        Degistir(ref isim1, ref isim2);
        Console.WriteLine($"Değiştirilen isimler: {isim1}, {isim2}");

        // Metot: İki ismin yerlerini değiştiren metot
        static void Degistir(ref string isim1, ref string isim2)
        {
            string gecici = isim1;
            isim1 = isim2;
            isim2 = gecici;
        }

        // Soru 14: Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğunu dönen bir metot.
        Console.Write("Sayı giriniz: ");
        int tekCiftSayi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Tek mi? " + TekMi(tekCiftSayi));

        // Metot: Sayının tek mi olduğunu döner
        static bool TekMi(int sayi)
        {
            return sayi % 2 == 1;
        }

        // Soru 15: Kullanıcıdan alınan hız ve zaman bilgileriyle, gidilen yolu hesaplayan bir metot yazınız.
        Hiz();

        static void Hiz()
        {
            Console.Write("Kaç saniye yol gittiniz: ");
            int sn = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ortalama kaç m/s hızla gittiniz: ");
            int ms = Convert.ToInt32(Console.ReadLine());

            int hiz = ms * sn; // Yol hesaplama
            Console.WriteLine($"Ortalama {ms} m/s hızla {sn} saniye gittiğiniz için\nOrtalama gittiğiniz yol: {hiz} metre");
        }

        // Soru 16: Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
        Console.Write("Dairenin yarıçapını giriniz: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Dairenin alanı: {Alan(r)}");

        static double Alan(double r)
        {
            return 3.14 * r * r; // Alan = π * r^2
        }

        // Soru 17: "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.
        string cumle = "Zaman bir GeRi SayIm";
        Console.WriteLine(cumle.ToUpper());
        Console.WriteLine(cumle.ToLower());

        // Soru 18: "    Selamlar   " metnini bir değişkene atayıp, başındaki ve sonundaki boşlukları siliniz.
        string boslukluMetin = "    Selamlar   ";
        Console.WriteLine(boslukluMetin.Trim());
    }
}