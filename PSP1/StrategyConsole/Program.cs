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
            vehicle.FuelTank = 200;
            vehicle.DriveFast(350, 99.7f);
            Console.ReadLine();
        }
    }
}
