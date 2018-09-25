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
            Vehicle vehicle = new Vehicle(new SlowEngine(), new HighQualityRadio());
            vehicle.FuelTank = 50;
            vehicle.DriveFast(350, 99.7f);

            Console.WriteLine();
            Console.WriteLine();

            Crane crane = new Crane(new SlowEngine());
            crane.FuelTank = 100;
            crane.LiftCargo(500, 35);
            Console.ReadLine();
        }
    }
}
