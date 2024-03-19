using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Polymorphism2
{
    class Vehicle
    {

        public virtual void carModel()
        {
            Console.WriteLine("This car is prototype.");
        }
    }

    class Broadway : Vehicle
    {
        public override void carModel()
        {
            Console.WriteLine("Broadway");
        }
    }

    class Clio : Vehicle
    {
        public override void carModel()
        {
            Console.WriteLine("Clio");
        }
    }

    class Megane : Vehicle
    {
        public override void carModel()
        {
            Console.WriteLine("Megane");
        }
    }
}
