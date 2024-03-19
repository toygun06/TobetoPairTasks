using System;
using System.Reflection;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            City1 mycity1 = new City1();
            City2 mycity2 = new City2();
            City3 mycity3 = new City3();

            Console.WriteLine(mycity1.city + " is the city of " + mycity1.country + ".");
            Console.WriteLine(mycity2.city + " is the city of " + mycity2.country + ".");
            Console.WriteLine(mycity3.city + " is the city of " + mycity3.country + ".");
        }
    }
}