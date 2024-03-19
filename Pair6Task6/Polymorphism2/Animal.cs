using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Polymorphism1
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("Animals are quiet.");
        }
    }

    class Bird : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Bird says: chirp chirp");
        }
    }

    class Lion : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Lion says: roar");
        }
    }

    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Cat says: meow meow");
        }
    }
}
