using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> urunler = new Dictionary<int, string>()
        {
            {1, "Bilgisayar"},
            {2, "Telefon"},
            {3, "Tablet"},
            {4, "Televizyon"},
            {5, "Oyun Konsolu"}
        };

        bool gecerliGiris = false;
        int secim;

        while (!gecerliGiris)
        {
            Console.WriteLine("Lütfen 1 ile 5 arası bir sipariş numarası giriniz:");

            // Kullanıcının girişini alıyoruz ve girdiyi tamsayıya dönüştürerek tamsayı kontrolünü yapıyoruz.
            gecerliGiris = int.TryParse(Console.ReadLine(), out secim);

            if (gecerliGiris && secim >= 1 && secim <= 5)
            {
                // switch-case yapısı kullanarak seçilen ürünün adını yazdırıyoruz
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Siparişiniz: " + urunler[1]);
                        break;
                    case 2:
                        Console.WriteLine("Siparişiniz: " + urunler[2]);
                        break;
                    case 3:
                        Console.WriteLine("Siparişiniz: " + urunler[3]);
                        break;
                    case 4:
                        Console.WriteLine("Siparişiniz: " + urunler[4]);
                        break;
                    case 5:
                        Console.WriteLine("Siparişiniz: " + urunler[5]);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen 1 ile 5 arasında bir sipariş numarası girin.");
                gecerliGiris = false;
            }
        }
    }
}
