using StrategyPattern;
using StrategyPattern.Engines;
using StrategyPattern.Radios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(new FastEngine(), new HighQualityRadio());
            vehicle.FuelTank = 200;
            vehicle.DriveFast(200, 99.7f);

            Console.WriteLine();
            Console.WriteLine();

            Crane crane = new Crane(new SlowEngine());
            crane.FuelTank = 100;
            crane.LiftCargo(500, 60);
            Console.ReadLine();
        }
    }
}
