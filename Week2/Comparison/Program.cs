using System;

namespace Karsilastirma
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Döngüsü
            int sayac = 0;
            Console.Write("Limit değeri giriniz: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            while (sayac <= limit)
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                sayac++;
            }
            //Do While Döngüsü
            int sayac2 = 0;
            Console.Write("Limit değeri giriniz: ");
            int limit2 = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                sayac2++;
            } 
            while (sayac2 <= limit2);
        }
        
        // While Döngüsü ve Do While Döngüsü arasındaki farklar : 
        
        // While döngüsünde istenen koşul sağlanmadığı sürece döngü çalışmaz.

        // Do While döngüsünde ise döngü en az bir kere çalışır ekrana girilen değeri yazdırır. Ardından koşul kontrol edilir ve koşul sağlanıyorsa döngü devam eder.Sağlanmıyorsa döngü sonlanır.

        // Aradaki önemli fark do while döngüsünde koşul sağlanmasa bile döngü en az bir kere çalışır.
    }
}