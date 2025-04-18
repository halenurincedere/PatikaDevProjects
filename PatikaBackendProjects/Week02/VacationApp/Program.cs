using System;

class Program
{
    static void Main()
    {
        string secilenLokasyon = "";
        int paketUcreti = 0;
        int kisiSayisi = 0;
        int ulasimUcreti = 0;

        do
        {
            // 1. Lokasyon seçimi
            do
            {
                
                Console.WriteLine("Tatil Arkadaşım Uygulamasına Hoşgeldiniz! ");
                Console.WriteLine("Tatil başlangıç paketlerimiz:");
                Console.WriteLine("Bodrum (₺4000), Marmaris (₺3000) veya Çeşme (₺5000). Size en uygun seçeneği giriniz (Bodrum, Marmaris, Çeşme):");
                string giris = Console.ReadLine().ToLower();

                if (giris == "bodrum" || giris == "marmaris" || giris == "çeşme")
                {
                    secilenLokasyon = giris;

                    if (secilenLokasyon == "bodrum")
                    {
                        paketUcreti = 4000;
                    }
                    else if (secilenLokasyon == "marmaris")
                    {
                        paketUcreti = 3000;
                    }
                    else if (secilenLokasyon == "çeşme")
                    {
                        paketUcreti = 5000;
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız! Geçerli lokasyonlar: Bodrum, Marmaris, Çeşme");
                }
            } while (true);

            // 2. Kişi sayısını sorma
            do
            {
                Console.WriteLine("Kaç kişi için tatil planlıyorsunuz? ");
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out kisiSayisi) && kisiSayisi > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız! Lütfen pozitif bir sayı giriniz.");
                }
            } while (true);

            // 3. Tatil özeti bilgisi
            Console.WriteLine("--------------------------------------------------");
            
            if (secilenLokasyon == "bodrum")
            {
                Console.WriteLine("Bodrum: Masmavi denizi, eşsiz plajları ve renkli gece hayatı ile ünlüdür. Rotanız : Bodrum Kalesi & Merkez => Tekne Turu (Koy gezileri, yüzme molaları) => Popüler Plajlar & Barlar Sokağı");
            }
            else if (secilenLokasyon == "marmaris")
            {
                Console.WriteLine("Marmaris: Doğal güzellikleri, çam ormanları ve yat turları ile tanınır. Rotanız: Marmaris Kalesi & Merkez => Tekne Turu (Marmaris Kalesi & Eski Çarşı => Tekne Turu (Cennet Adası, Fosforlu Mağara) => İçmeler veya Turunç Plajı");
            }
            else if (secilenLokasyon == "çeşme")
            {
                Console.WriteLine(" Çeşme: Muhteşem rüzgar sörfü alanları, termal otelleri ve eşsiz kum plajlarıyla ünlüdür. Rotanız : Çeşme Kalesi & Merkez => Alaçatı Turu & Rüzgar Sörfü => Ilıca veya Pırlanta Plajı ");
            }

            // 4. Ulaşım seçimi
            do
            {
                Console.WriteLine("Tatiline ne şekilde gitmek istersiniz?");
                Console.WriteLine("1 - Kara yolu (Kişi başı ₺1500)");
                Console.WriteLine("2 - Hava yolu (Kişi başı ₺4000)");
                Console.Write("Lütfen bir seçenek seçiniz (1 ya da 2): ");
                string ulasimSecimi = Console.ReadLine();

                if (ulasimSecimi == "1")
                {
                    ulasimUcreti = 1500;
                    break;
                }
                else if (ulasimSecimi == "2")
                {
                    ulasimUcreti = 4000;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız! Lütfen '1' ya da '2' seçiniz.");
                }
            } while (true);

            // Kişi başı toplam maliyet hesaplama
            int kisiBasiToplamFiyat = paketUcreti + ulasimUcreti;
            // Toplam maliyet hesaplama
            int toplamTatilUcreti = kisiBasiToplamFiyat * kisiSayisi;

            // Sonuçları yazdırma
            Console.WriteLine("\n------------- Tatil Planı --------------");
            Console.WriteLine("Seçilen Lokasyon: " + secilenLokasyon);
            Console.WriteLine("Kişi Sayısı: " + kisiSayisi);
            Console.WriteLine("Ulaşım Türü: " + (ulasimUcreti == 1500 ? "Kara yolu" : "Hava yolu"));
            Console.WriteLine("Kişi Başı Ücret: ₺ " + kisiBasiToplamFiyat );
            Console.WriteLine("Toplam Tatil Ücreti: ₺ " + toplamTatilUcreti );

            // 5. Başka bir tatil planlamak isteyip istemediğini sorma
            Console.WriteLine("\nBaşka bir tatil planlamak ister misiniz? (Evet/Hayır)");
            string cevap = Console.ReadLine().ToLower();

            if (cevap != "evet")
            {
                Console.WriteLine("İyi günler dileriz!");
                break; // Çıkış
            }
        } while (true); // Döngü yeniden başlar eğer kullanıcı "Evet" derse
    }
}