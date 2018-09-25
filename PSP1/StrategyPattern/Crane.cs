using StrategyPattern.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Crane
    {
        public float FuelTank { get; set; }
        public const int LiftingSpeed = 5;

        IEngine _engine;
        public Crane(IEngine engine)
        {
            _engine = engine;
        }

        public void LiftCargo(int weight, int height)
        {
            int RPMneeded = WeightToRPM(weight);
            if(RPMneeded > _engine.MaxRPM)
            {
                Console.WriteLine("Engine isnt good enough");
                return;
            }
            int currentHeight = 0;
            _engine.TurnOn();
            Console.WriteLine("Turning on the engine");
            while (height > currentHeight)
            {
                FuelTank -= _engine.Consumption;
                Console.WriteLine($"\t Fuel left: {FuelTank}");
                if (FuelTank <= 0)
                {
                    Console.WriteLine("OUT OF FUEL");
                    break;
                }
                if (_engine.RPM < RPMneeded)
                {
                    _engine.Accelerate();
                    Console.WriteLine($"Accelerating to {_engine.RPM} RPM");
                }
                else
                {
                    currentHeight += LiftingSpeed;
                    Console.WriteLine($"Lifting cargo. Height = {currentHeight}");
                }
            }
            _engine.TurnOff();
            Console.WriteLine("Turning off the engine");
        }

        private int WeightToRPM(int weight)
        {
            return weight * 4;
        }
    }
}
