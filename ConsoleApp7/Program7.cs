using System;

class Program
{
    static void Main()
    {
        Console.Write("Öğrenci sayısını girin: ");
        int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= ogrenciSayisi; i++)
        {
            Console.WriteLine("Öğrenci #" + i);
            Console.Write("Adı: ");
            string ad = Console.ReadLine();

            Console.Write("Soyadı: ");
            string soyad = Console.ReadLine();

            int s1, s2, s3;

            // 1. sınav notunu alırken kontrol yapısı
            do
            {
                Console.Write("1. Sınav Notu (0-100): ");
            } while (!int.TryParse(Console.ReadLine(), out s1) || s1 < 0 || s1 > 100);

            // 2. sınav notunu alırken kontrol yapısı
            do
            {
                Console.Write("2. Sınav Notu (0-100): ");
            } while (!int.TryParse(Console.ReadLine(), out s2) || s2 < 0 || s2 > 100);

            // 3. sınav notunu alırken kontrol yapısı
            do
            {
                Console.Write("3. Sınav Notu (0-100): ");
            } while (!int.TryParse(Console.ReadLine(), out s3) || s3 < 0 || s3 > 100);

            double ortalama = (s1 + s2 + s3) / 3;
            Console.WriteLine("Not Ortalaması: " + ortalama);
            Console.WriteLine();
        }
    }
}
