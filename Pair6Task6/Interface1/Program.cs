//Arayüzler(Interfaces):

//Arayüzler, bir veya daha fazla metodu, özelliği ve olayı tanımlayan bir sözleşmedir.
//Bir sınıf birden fazla arayüzü uygulayabilir (multiple inheritance).
//Arayüzler sadece imza (signature) sağlar; yani metotların ve özelliklerin gövdesi (body) yoktur.
//Arayüzler, farklı sınıfların aynı davranışları sergilemesini sağlar, bu da daha fazla esneklik sağlar ve kodun daha okunabilir ve bakımı daha kolay hale getirir.
//Bir sınıfın bir arayüzü uygulaması, o sınıfın o arayüzde tanımlanan tüm metotları ve özellikleri uygulamasını zorunlu kılar.
//Arayüzler, soyutlama için kullanılır; yani bir nesnenin belirli bir davranışı sağladığı garanti edilir.

//Farklar:

//Kullanım: Abstract sınıflar, somut ve soyut üyeleri bir araya getirirken, arayüzler sadece imza sağlar.
//Kalıtım: Abstract sınıflar kalıtım ile genişletilirken, arayüzler uygulanır.
//Somut Üyeler: Abstract sınıflar somut üyeler içerebilirken, arayüzler sadece imzalara sahiptir.
//Çoklu Kalıtım: Bir sınıf birden fazla arayüzü uygulayabilir, ancak bir sınıf yalnızca bir abstract sınıftan kalıtım alabilir.

using System;

namespace AbstractVsInterface
{
    interface IShape
    {
        double Area();
    }

    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
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
