using System;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelA myModelA = new ModelA();
            ModelQ myModelQ = new ModelQ();
            ModelRS myModelRS = new ModelRS();

            //myModelA.brandClass("A series");
            //myModelQ.brandClass("Q series");
            //myModelRS.brandClass("RS seris");

            Console.WriteLine(myModelA.brand + " " + myModelA.modelSeries);
            Console.WriteLine(myModelQ.brand + " " + myModelQ.modelSeries);
            Console.WriteLine(myModelRS.brand + " " + myModelRS.modelSeries);
        }
    }
}