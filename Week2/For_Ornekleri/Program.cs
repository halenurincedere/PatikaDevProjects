using System;

namespace For_Ornekleri
{
    class Program
    {
        static void Main(string[] args)

        // Aşama 1:Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }

            // Aşama 2:  1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Sayılar: {i}");
            }

            // Aşama 3: 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            for (int i = 2; i < 20; i += 2)
            {
                Console.WriteLine($"Çift Sayılar: {i}");
            }

            // Aşama 4: 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            int toplam = 0;
            for (int i = 50; i < 150; i++)
            {
                toplam += i;
            }
            Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam}");

            // Aşama 5: 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
            //Yapay zekadan yardım alarak çözdüm.

            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 1; i < 120; i++)
            {
                tekToplam += (i % 2 == 1) ? i : 0; //Tek sayıların toplamı.
                ciftToplam += (i % 2 == 0) ? i : 0; //Çift sayıların toplamı.
            }
            Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {tekToplam}");
            Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {ciftToplam}");
        }
    }
}