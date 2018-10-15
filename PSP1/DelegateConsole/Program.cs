using DelegatePattern.Functionality.Interfaces;
using DelegatePattern.Mixin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var superTruck = new SuperTruck();
            superTruck.OpenRoof();
            superTruck.ListenToMusic(99.7f);
            superTruck.TransportCargo(100, 500);
            superTruck.CloseRoof();
            superTruck.Fly(3000);

            Console.WriteLine();
            Console.WriteLine();

            M1(superTruck, 99.7f);
            M2(superTruck, 200);
            Console.ReadLine();
        }

        static void M1(IRadio r, float frequency)
        {
            r.ListenToMusic(frequency);
        }

        static void M2(IWings w, int distance)
        {
            w.Fly(distance);
        }
    }
}
