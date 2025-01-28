using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Rastgele sayı listesi
        Random random = new Random();
        List<int> numbers = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(-100, 100));
        }
        Console.WriteLine("Orijinal Liste:");
        Console.WriteLine(string.Join(", ", numbers));

        // 2. Çift olan sayılar
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("\nÇift Olan Sayılar:");
        Console.WriteLine(string.Join(", ", evenNumbers));

        // 3. Tek olan sayılar
        var oddNumbers = numbers.Where(n => n % 2 != 0);
        Console.WriteLine("\nTek Olan Sayılar:");
        Console.WriteLine(string.Join(", ", oddNumbers));

        // 4. Negatif sayılar
        var negativeNumbers = numbers.Where(n => n < 0);
        Console.WriteLine("\nNegatif Sayılar:");
        Console.WriteLine(string.Join(", ", negativeNumbers));

        // 5. Pozitif sayılar
        var positiveNumbers = numbers.Where(n => n > 0);
        Console.WriteLine("\nPozitif Sayılar:");
        Console.WriteLine(string.Join(", ", positiveNumbers));

         // 6. 15'ten büyük ve 22'den küçük sayılar
        var between15and22 = numbers.Where(n => n > 15 && n < 22);
        Console.WriteLine("\n15'ten Büyük ve 22'den Küçük Sayılar:");
        Console.WriteLine(string.Join(", ", between15and22));

        // 7. Sayıların kareleri
        var squaredNumbers = numbers.Select(n => n * n);
        Console.WriteLine("\nSayıların Kareleri:");
        Console.WriteLine(string.Join(", ", squaredNumbers));
    }
}