using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<object> mixedList = new List<object>();

        mixedList.Add(10);
        mixedList.Add("Hello");
        mixedList.Add(3.14);
        mixedList.Add(true);

        foreach (var item in mixedList)
        {
            Console.WriteLine(item);
        }
    }
}
