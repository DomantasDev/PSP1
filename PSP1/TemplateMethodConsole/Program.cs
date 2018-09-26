using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Cranes;
using TemplateMethod.Vehicles;

namespace TemplateMethodConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleWithSlowEngineAndLowQualityRadio vehicle = new VehicleWithSlowEngineAndLowQualityRadio();
            vehicle.FuelTank = 200;
            vehicle.DriveFast(200, 99.7f);

            Console.WriteLine();
            Console.WriteLine();

            CraneWithFastEngine crane = new CraneWithFastEngine();
            crane.FuelTank = 200;
            crane.LiftCargo(1000, 30);
            Console.ReadLine();
        }
    }
}
