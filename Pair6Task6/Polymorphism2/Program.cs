using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Polymorphism1
{

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myBird = new Bird();
            Animal myLion = new Lion();
            Animal myCat = new Cat();

            myAnimal.animalSound();
            myBird.animalSound();
            myLion.animalSound();
            myCat.animalSound();
        }
    }
}
