using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int rastgeleSayi = random.Next(1, 11);
        int tahmin = 0;

        Console.WriteLine("1'den 10'a kadar bir sayıyı tahmin edin.");

        while (tahmin != rastgeleSayi)
        {
            Console.Write("Tahmininiz: ");
            int.TryParse(Console.ReadLine(), out tahmin);

            if (tahmin < 1 || tahmin > 10)
            {
                Console.WriteLine("Lütfen 1 ile 10 arasında bir sayı giriniz.");
                continue;
            }

            if (tahmin < rastgeleSayi)
            {
                Console.WriteLine("Daha büyük bir sayı giriniz.");
            }
            else if (tahmin > rastgeleSayi)
            {
                Console.WriteLine("Daha küçük bir sayı giriniz.");
            }
            else
            {
                Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
            }
        }
    }
}
