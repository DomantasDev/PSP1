using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Vehicles
{
    public abstract class Vehicle
    {

        public float FuelTank { get; set; }
        public int CurrentSpeed { get; private set; }

        protected abstract int RPM { get; }
        protected abstract int MaxRPM { get;}
        protected abstract float Consumption { get;}
        protected abstract bool EngineIsOn { get;}

        protected abstract bool RadioIsOn { get;}
        protected abstract float Frequency { get;}

        protected abstract void TurnOnEngine();
        protected abstract void Accelerate();
        protected abstract void Decelerate();
        protected abstract void TurnOffEngine();

        protected abstract void TurnOnRadio();
        protected abstract void ChangeFrequency(float frequency);
        protected abstract string NowPlaying();
        protected abstract void TurnOffRadio();

        public void DriveEconomically(int distance)
        {
            int distanceToAccelerate = 0;
            TurnOnEngine();
            Console.WriteLine("Turning on the engine");
            CurrentSpeed = RPMToSpeed(RPM);
            Console.WriteLine($"Starting speed: {CurrentSpeed}");
            if (FuelTank > 0)
                while (distance > 0)
                {
                    distance -= CurrentSpeed;
                    FuelTank -= Consumption;
                    Console.WriteLine($"\t Fuel left: {FuelTank}");
                    if (FuelTank <= 0)
                    {
                        Console.WriteLine("OUT OF FUEL");
                        break;
                    }
                    if (distance - distanceToAccelerate <= 0)
                    {
                        Decelerate();
                        CurrentSpeed = RPMToSpeed(RPM);
                        Console.WriteLine($"Decelerating to {CurrentSpeed}");
                    }
                    else if (RPM < 2000)
                    {
                        distanceToAccelerate += CurrentSpeed;
                        Accelerate();
                        CurrentSpeed = RPMToSpeed(RPM);
                        Console.WriteLine($"Accelerating to {CurrentSpeed}");
                    }
                    else
                    {
                        Console.WriteLine($"Maintaining speed {CurrentSpeed}");
                    }
                }
            TurnOffEngine();
            Console.WriteLine("Turning off the engine");
        }

        public void DriveFast(int distance, float radioFrequency)
        {
            int distanceToAccelerate = 0;
            TurnOnEngine();
            Console.WriteLine("Turning on the engine");
            TurnOnRadio();
            Console.WriteLine("Turning on the radio");
            ChangeFrequency(radioFrequency);
            Console.WriteLine(NowPlaying());
            CurrentSpeed = RPMToSpeed(RPM);
            Console.WriteLine($"Starting speed: {CurrentSpeed}");
            if (FuelTank > 0)
                while (distance > 0)
                {
                    distance -= CurrentSpeed;
                    FuelTank -= Consumption;
                    Console.WriteLine($"\t Fuel left: {FuelTank}");
                    if (FuelTank <= 0)
                    {
                        Console.WriteLine("OUT OF FUEL");
                        break;
                    }
                    if (distance - distanceToAccelerate <= 0)
                    {
                        Decelerate();
                        CurrentSpeed = RPMToSpeed(RPM);
                        Console.WriteLine($"Decelerating to {CurrentSpeed}");
                    }
                    else if (RPM != MaxRPM)
                    {
                        distanceToAccelerate += CurrentSpeed;
                        Accelerate();
                        CurrentSpeed = RPMToSpeed(RPM);
                        Console.WriteLine($"Accelerating to {CurrentSpeed}");
                    }
                    else
                    {
                        Console.WriteLine($"Maintaining speed {CurrentSpeed}");
                    }
                }
            TurnOffEngine();
            Console.WriteLine("Turning off the engine");
            TurnOffRadio();
            Console.WriteLine("Turning off the radio");
        }

        private int RPMToSpeed(int RPM)
        {
            return (int)Math.Round((float)RPM / 100 * 4);
        }
    }
}
