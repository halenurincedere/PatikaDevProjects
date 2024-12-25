using System;

namespace TatilUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proje adımları: Tatil Uygulaması lokasyon seçimi, kişi sayısı girişi, ulaşım türü seçimi, toplam maliyet hesaplama sırarıyla oluşturulacak. Girdilerde büyük küçük harf duyarlılığı olacak. Son işlemde kullanıcıya toplam maliyet bilgisi verilecek. Kullanıcıya devam etmek isteyip istemediği sorulacak. Devam etmek istemiyorsa uygulama sonlanacak.Devam etmek istiyorsa başa dönecek.

            bool devamEt = true;
            while (devamEt)
            {
                //Lokasyon seçimi. Switch case yapısı kullanılabilirdi ama if else yapısı kullanıldı.
                string lokasyon = "";
                int paketFiyati = 0;
                while (true)
                {
                    Console.WriteLine("Lütfen bir lokasyon seçin: Bodrum, Marmaris, Çeşme");
                    lokasyon = Console.ReadLine().ToLower();

                    if (lokasyon == "bodrum")
                    {
                        paketFiyati = 4000;
                        break;
                    }
                    else if (lokasyon == "marmaris")
                    {
                        paketFiyati = 3000;
                        break;
                    }
                    else if (lokasyon == "çeşme")
                    {
                        paketFiyati = 5000;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz lokasyon. Lütfen Bodrum, Marmaris veya Çeşme yazınız.");
                    }
                }
            }
        }
    }
}