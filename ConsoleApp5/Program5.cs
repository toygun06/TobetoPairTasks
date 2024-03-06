using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        bool mukemmel = IsPerfectNumber(sayi);

        if (mukemmel)
        {
            Console.WriteLine(sayi + " mükemmel bir sayıdır.");
        }
        else
        {
            Console.WriteLine(sayi + " mükemmel bir sayı değildir.");
        }
    }

    static bool IsPerfectNumber(int num)
    {
        int toplam = 0;

        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                toplam += i;
            }
        }

        return toplam == num;
    }
}
