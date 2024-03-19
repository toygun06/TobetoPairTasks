using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tyre1 mytyre1 = new Tyre1();
            Tyre2 mytyre2 = new Tyre2();
            Tyre3 mytyre3 = new Tyre3();
            Tyre4 mytyre4 = new Tyre4();

            Console.WriteLine(mytyre1.tyre1 + " " + mytyre1.vehicle);
            Console.WriteLine(mytyre2.tyre2 + " " + mytyre2.vehicle);
            Console.WriteLine(mytyre3.tyre3 + " " + mytyre3.vehicle);
            Console.WriteLine(mytyre4.tyre4 + " " + mytyre4.vehicle);
        }
    }
}