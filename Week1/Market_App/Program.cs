using System;

namespace MarketApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MarketApp!");
            Console.WriteLine("Apple = ₺10\nPear = ₺10\nStrawberry = ₺15\nBanana = ₺20\nOther fruits = ₺40");

            Console.Write("Which fruit would you like to buy? (Apple/Pear/Strawberry/Banana/Other): ");
            string? fruit = Console.ReadLine();

            // Null veya boş kontrolü için if/else
            if (string.IsNullOrWhiteSpace(fruit))
            {
                Console.WriteLine("Please enter a valid fruit name!");
                return; // Programı sonlandır
            }

            // Fazla boşlukları kaldır ve küçük harfe çevir
            fruit = fruit.Trim().ToLower();
            int price;

            // Giriş geçerli mi? Ön kontrol
            if (fruit != "apple" && fruit != "pear" && fruit != "strawberry" && fruit != "banana" && fruit != "other")
            {
                Console.WriteLine("Sorry, we don't recognize that fruit. Please try again.");
                return; // Programı sonlandır
            }
            // Switch/Case, daha düzenli, okunabilir bir yapı sunduğundan tercih ettim.

            // Giriş geçerliyse fiyatı belirle
            switch (fruit)
            {
                case "apple":
                case "pear":
                    price = 10;
                    break;
                case "strawberry":
                    price = 15;
                    break;
                case "banana":
                    price = 20;
                    break;
                default:
                    price = 40; // Diğer tüm meyveler
                    break;
            }

            Console.WriteLine($"The price of your selected fruit is: ₺{price}. Redirecting to the payment page...");
            System.Threading.Thread.Sleep(2000); // Simulate a delay
            Console.WriteLine("Payment page is ready. Please proceed with your payment!");

            // Eğlenceli olsun. Şifre isteyelim.
            Console.Write("Please enter your payment password: ");
            string? password = Console.ReadLine();
            Console.WriteLine("Payment successful! Thank you for your purchase.");
        }
    }
}