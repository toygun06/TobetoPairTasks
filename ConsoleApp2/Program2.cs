using System;
using System.Collections.Generic;

class Program2
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

        Dictionary<int, decimal> urunFiyatlari = new Dictionary<int, decimal>()
        {
            {1, 2500},  // Bilgisayar fiyatı
            {2, 1500},  // Telefon fiyatı
            {3, 1000},  // Tablet fiyatı
            {4, 3000},  // Televizyon fiyatı
            {5, 2000}   // Oyun Konsolu fiyatı
        };

        bool gecerliGiris = false;
        int secilenUrunID;
        int adet;

        while (!gecerliGiris)
        {
            Console.WriteLine("Lütfen 1 ile 5 arası bir ürün numarası giriniz:");
            gecerliGiris = int.TryParse(Console.ReadLine(), out secilenUrunID);

            if (gecerliGiris && urunler.ContainsKey(secilenUrunID))
            {
                Console.WriteLine("Lütfen kaç adet almak istediğinizi giriniz:");
                gecerliGiris = int.TryParse(Console.ReadLine(), out adet);

                if (gecerliGiris && adet > 0)
                {
                    decimal toplamFiyat = urunFiyatlari[secilenUrunID] * adet;
                    Console.WriteLine($"{adet} adet {urunler[secilenUrunID]} için ödemeniz gereken tutar {toplamFiyat} TL'dir.");
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir sayı girin.");
                    gecerliGiris = false;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen 1 ile 5 arasında bir ürün numarası girin.");
            }
        }
    }
}
