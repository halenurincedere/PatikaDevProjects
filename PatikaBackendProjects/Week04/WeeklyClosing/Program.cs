using System;

// Base class
abstract class BaseMakine
{
    public DateTime UretimTarihi { get; private set; } = DateTime.Now;
    public string SeriNumarasi { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public string IsletimSistemi { get; set; }

    public virtual void BilgileriYazdir()
    {
        Console.WriteLine($"\nÜretim Tarihi: {UretimTarihi}\nSeri Numarası: {SeriNumarasi}\nAd: {Ad}\nAçıklama: {Aciklama}\nİşletim Sistemi: {IsletimSistemi}");
    }

    public abstract void UrunAdiGetir();
}

// Telefon class
class Telefon : BaseMakine
{
    public bool TrLisansliMi { get; set; }

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"Türkiye Lisanslı: {TrLisansliMi}");
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
    }
}

// Bilgisayar class
class Bilgisayar : BaseMakine
{
    private int usbGirisSayisi;
    public int UsbGirisSayisi
    {
        get => usbGirisSayisi;
        set
        {
            if (value == 2 || value == 4)
                usbGirisSayisi = value;
            else
            {
                usbGirisSayisi = -1;
                Console.WriteLine("Geçersiz USB giriş sayısı! 2 veya 4 olmalıdır.");
            }
        }
    }
    public bool BluetoothVarMi { get; set; }

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}\nBluetooth: {BluetoothVarMi}");
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Bir ürün üretmek için seçim yapınız:\n1 - Telefon\n2 - Bilgisayar\n3 - Çıkış");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Telefon telefon = new Telefon();

                Console.Write("Seri Numarası: ");
                telefon.SeriNumarasi = Console.ReadLine();

                Console.Write("Ad: ");
                telefon.Ad = Console.ReadLine();

                Console.Write("Açıklama: ");
                telefon.Aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi: ");
                telefon.IsletimSistemi = Console.ReadLine();

                Console.Write("Türkiye Lisanslı mı? (true/false): ");
                telefon.TrLisansliMi = bool.Parse(Console.ReadLine());

                Console.WriteLine("Telefon başarıyla üretildi!");
                telefon.BilgileriYazdir();
                telefon.UrunAdiGetir();
            }
            else if (secim == "2")
            {
                Bilgisayar bilgisayar = new Bilgisayar();

                Console.Write("Seri Numarası: ");
                bilgisayar.SeriNumarasi = Console.ReadLine();

                Console.Write("Ad: ");
                bilgisayar.Ad = Console.ReadLine();

                Console.Write("Açıklama: ");
                bilgisayar.Aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi: ");
                bilgisayar.IsletimSistemi = Console.ReadLine();

                Console.Write("USB Giriş Sayısı (2 veya 4): ");
                bilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());

                Console.Write("Bluetooth var mı? (true/false): ");
                bilgisayar.BluetoothVarMi = bool.Parse(Console.ReadLine());

                Console.WriteLine("Bilgisayar başarıyla üretildi!");
                bilgisayar.BilgileriYazdir();
                bilgisayar.UrunAdiGetir();
            }
            else if (secim == "3")
            {
                Console.WriteLine("İyi günler! Uygulamadan çıkılıyor...");
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim! Lütfen 1, 2 veya 3 giriniz.");
            }

            Console.WriteLine("Başka bir ürün üretmek istiyor musunuz? (E/H)");
            string devam = Console.ReadLine();
            if (devam.ToUpper() != "E")
            {
                Console.WriteLine("İyi günler!");
                break;
            }
        }
    }
}