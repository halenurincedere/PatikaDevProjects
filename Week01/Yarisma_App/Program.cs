using System;

namespace Yarisma_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bilgi yarışması başlangıç ekranı
            Console.WriteLine("---------------- Kim Milyoner Olmak İster ---------------");
            Console.WriteLine("13 Soruluk Bilgi Yarışmamızda finale kalarak son 3 soruyu yanıtlamaya hak kazandınız. Bu 3 sorudan 2’sini doğru yanıtlarsanız, 1 Milyon ₺ kazanacaksınız!\nHazır mısınız? O zaman başlayalım!");

            int correctAnswers = 0; // Doğru cevap sayacı

            // Soru 11
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Soru 11) Harry Potter serisinde Lord Voldemort’un gerçek adı nedir?\nA) Severus Snape \nB) Tom Marvolo Riddle");
            Console.Write("Cevabınızı A ya da B şeklinde giriniz: ");
            string? a1 = Console.ReadLine()?.ToUpper();

            if (a1 == "B")
            {
                Console.WriteLine("Tebrikler! Sonraki soruya geçebilirsiniz.");
                correctAnswers++; //Yapay zeka yardımıyla
            }
            else
            {
                Console.WriteLine("Yanlış Cevap! Doğru cevap: Tom Marvolo Riddle. Büyük ödülü kazanmak için son 2 soruyu doğru yanıtlamalısınız.");
            }

            // Soru 12
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Soru 12) Disney’in Aladdin filminde Cin’i seslendiren ünlü oyuncu kimdir?\nA) Robin Williams \nB) Jim Carrey");
            Console.Write("Cevabınızı A ya da B şeklinde giriniz: ");
            string? a2 = Console.ReadLine()?.ToUpper();

            if (a2 == "A")
            {
                Console.WriteLine("Tebrikler! Doğru cevap.");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine("Yanlış Cevap! Doğru cevap: Robin Williams.");
            }

            // Olasılık değerlendirmesi
            Console.WriteLine("--------------------------------------------------------");
            if (correctAnswers == 2)
            {
                Console.WriteLine("Tebrikler! Son soruya gelmeden 1 Milyon ₺ kazandınız. Son soruyu yine de görelim!");
            }
            else if (correctAnswers == 1)
            {
                Console.WriteLine("Kazanma ihtimaliniz %50. Son soruya geçerek şansınızı deneyin!");
            }
            else
            {
                Console.WriteLine("Kazanma ihtimaliniz %0. Ama son soruyu yine de cevaplayabilirsiniz!");
            }

            // Soru 13
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Soru 13) Dünya üzerindeki en derin nokta neresidir?\nA) Mariana Çukuru \nB) Tonga Çukuru");
            Console.Write("Cevabınızı A ya da B şeklinde giriniz: ");
            string? a3 = Console.ReadLine()?.ToUpper();

            if (a3 == "A")
            {
                Console.WriteLine("Tebrikler! Doğru cevap.");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine("Yanlış Cevap! Doğru cevap: Mariana Çukuru.");
            }

            // Final değerlendirme
            Console.WriteLine("--------------------------------------------------------");
            if (correctAnswers >= 2)
            {
                Console.WriteLine($"Tebrikler! {correctAnswers} doğru cevap ile 1 Milyon ₺ kazandınız!");
            }
            else
            {
                Console.WriteLine($"Üzgünüz! {correctAnswers} doğru cevap verdiniz. Büyük ödülü kazanamadınız.");
            }
        }
    }
}