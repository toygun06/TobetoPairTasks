//Abstract Sınıflar:

//Bir sınıf, bir veya daha fazla abstract üyenin bulunduğu bir sınıftır.
//Abstract sınıflar hem somut (concrete) hem de soyut üyeler içerebilir.
//Somut üyeleri (metodlar, özellikler, alanlar) bulunabilir ve bunlar alt sınıflar tarafından doğrudan kullanılabilir.
//Abstract sınıflar, alt sınıflar tarafından kalıtım alınabilir.
//Genellikle bir kalıtım yapısında, ortak özellikleri paylaşmak için kullanılır.
//Abstract sınıflar, kalıtım yoluyla genişletilebilir, yani alt sınıflar içeriklerini değiştirebilir.

//Farklar:

//Kullanım: Abstract sınıflar, somut ve soyut üyeleri bir araya getirirken, arayüzler sadece imza sağlar.
//Kalıtım: Abstract sınıflar kalıtım ile genişletilirken, arayüzler uygulanır.
//Somut Üyeler: Abstract sınıflar somut üyeler içerebilirken, arayüzler sadece imzalara sahiptir.
//Çoklu Kalıtım: Bir sınıf birden fazla arayüzü uygulayabilir, ancak bir sınıf yalnızca bir abstract sınıftan kalıtım alabilir.

using System;

namespace AbstractVsInterface
{
    abstract class Shape
    {
        public abstract double Area();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine("Circle Area: " + circle.Area());
        }
    }
}
