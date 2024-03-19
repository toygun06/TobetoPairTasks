using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Polymorphism2
{

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle();
            Vehicle myBroadway = new Broadway();
            Vehicle myClio = new Clio();
            Vehicle myMegane = new Megane();

            myVehicle.carModel();
            myBroadway.carModel();
            myClio.carModel();
            myMegane.carModel();
        }
    }
}
