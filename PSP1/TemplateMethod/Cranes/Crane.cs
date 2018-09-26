using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Cranes
{
    public abstract class Crane
    {
        public float FuelTank { get; set; }
        public const int LiftingSpeed = 5;

        protected abstract int RPM { get; }
        protected abstract int MaxRPM { get; }
        protected abstract float Consumption { get; }
        protected abstract bool EngineIsOn { get; }

        protected abstract void TurnOnEngine();
        protected abstract void Accelerate();
        protected abstract void Decelerate();
        protected abstract void TurnOffEngine();

        public void LiftCargo(int weight, int height)
        {
            int RPMneeded = WeightToRPM(weight);
            if (RPMneeded > MaxRPM)
            {
                Console.WriteLine("Engine isnt good enough");
                return;
            }
            int currentHeight = 0;
            TurnOnEngine();
            Console.WriteLine("Turning on the engine");
            if (FuelTank > 0)
                while (height > currentHeight)
                {
                    FuelTank -= Consumption;
                    Console.WriteLine($"\t Fuel left: {FuelTank}");
                    if (FuelTank <= 0)
                    {
                        Console.WriteLine("OUT OF FUEL");
                        break;
                    }
                    if (RPM < RPMneeded)
                    {
                        Accelerate();
                        Console.WriteLine($"Accelerating to {RPM} RPM");
                    }
                    else
                    {
                        currentHeight += LiftingSpeed;
                        Console.WriteLine($"Lifting cargo. Height = {currentHeight}");
                    }
                }
            if (FuelTank > 0)
                while (RPM > 1000)
                {
                    Decelerate();
                    Console.WriteLine($"Decelerating to {RPM} RPM");
                }
            TurnOffEngine();
            Console.WriteLine("Turning off the engine");
        }

        private int WeightToRPM(int weight)
        {
            return weight * 4;
        }
    }
}
