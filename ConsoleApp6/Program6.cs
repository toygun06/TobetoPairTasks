using System;

class Program
{
    static void Main()
    {
        // 1. Length: Stringin karakter sayısını döndürür.
        string str = "Hello";
        int length = str.Length;
        Console.WriteLine("Length: " + length); // Length: 5

        // 2. IndexOf: Belirtilen bir karakterin veya alt stringin ilk indeksini döndürür.
        int index = str.IndexOf("H");
        Console.WriteLine("IndexOf: " + index); // IndexOf: 0

        // 3. Substring: Belirtilen indeksten başlayarak belirtilen sayıda karakter içeren alt stringi döndürür.
        string subStr = str.Substring(1, 3);
        Console.WriteLine("Substring: " + subStr); // Substring: ell

        // 4. ToUpper and ToLower: Stringin tüm karakterlerini büyük veya küçük harfe dönüştürür.
        string upperStr = str.ToUpper();
        string lowerStr = str.ToLower();
        Console.WriteLine("ToUpper: " + upperStr); // ToUpper: HELLO
        Console.WriteLine("ToLower: " + lowerStr); // ToLower: hello

        // 5. Replace: Belirli bir karakter veya alt stringi başka bir karakter veya stringle değiştirir.
        string newStr = str.Replace("Hello", "Hi");
        Console.WriteLine("Replace: " + newStr); // Replace: Hi

        // 6. Trim: Stringin başındaki ve sonundaki boşlukları kaldırır.
        string trimmedStr = "   Hello   ".Trim();
        Console.WriteLine("Trim: " + trimmedStr); // Trim: Hello

        // 7. Split: Belirtilen bir ayraç karakterine göre stringi parçalar ve bir dizi string olarak döndürür.
        string splitStr = "Hello,World,C#";
        string[] arr = splitStr.Split(',');
        Console.WriteLine("Split:");
        foreach (string s in arr)
        {
            Console.WriteLine(s);
        }

        // 8. Concat: İki veya daha fazla stringi birleştirir.
        string str1 = "Hello";
        string str2 = "World";
        string combinedStr = string.Concat(str1, " ", str2);
        Console.WriteLine("Concat: " + combinedStr); // Concat: Hello World
    }
}
