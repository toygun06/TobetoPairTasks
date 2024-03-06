using System;
//Belirli bir koşul sağlandığı sürece iki döngü de devam eder. Aralarındaki tek bir fark vardır;
//While döngüsü koşulu kontrol ederek çalışmaya başlar,
//Do-while döngüsü bloğu bir döngü çalıştırır sonra koşulu kontrol eder.

//Aşağıdaki örnekte while döngüsü koşulu sağlamadığı için çalışmayacaktır.
//Do-while döngüsündeki değişken koşula uygun olmamasına rağmen ekrana basılır.
class Program1
{
    static void Main()
    {
        int i = 6;

        while (i <= 5)
        {
            Console.WriteLine("While döngüsü: " + i);
            i++;
        }

        int x = 6;

        do
        {
            Console.WriteLine("Do-While döngüsü: " + x);
            x++;
        } while (x <= 5);
    }
}
