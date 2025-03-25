using System;

namespace While_Ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru 1: Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
            int sayac = 1;
            while (sayac <= 10)
            {
                Console.WriteLine($" {sayac}  Kendime inanıyorum, ben bu yazılım işini hallederim!");
                sayac++;
            }

            // Soru 2: 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            int sayi = 1;
            while (sayi <= 20)
            {
                Console.WriteLine(sayi);
                sayi++;
            }

            //Soru 3: 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            int i = 1;
            while (i <= 20)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            // Soru 4: 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            int sayi2 = 50;
            int toplam = 0;
            while (sayi2 <= 150)
            {
                toplam += sayi2;
                sayi2++;
            }
            Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam}");

            // Soru 5 : 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

            int sayi3 = 1;
            int tekToplam = 0;
            int ciftToplam = 0;
            while (sayi3 <= 120)
            {
                if (sayi3 % 2 == 0)
                {
                    ciftToplam += sayi3;
                }
                else
                {
                    tekToplam += sayi3;
                }
                sayi3++;
            }
            Console .WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {tekToplam}");
            Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {ciftToplam}");
    }
}
}