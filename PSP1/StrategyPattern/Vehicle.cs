using StrategyPattern.Engines;
using StrategyPattern.Radios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Vehicle
    {
        IEngine _engine;
        IRadio _radio;
        public float FuelTank { get; set; }
        public int CurrentSpeed { get; private set; }

        public Vehicle(IEngine engine, IRadio radio)
        {
            _engine = engine;
            _radio = radio;
        }

        public void DriveEconomically(int distance)
        {
            int distanceToAccelerate = 0;
            _engine.TurnOn();
            Console.WriteLine("Turning on the engine");
            CurrentSpeed = RPMToSpeed(_engine.RPM);
            Console.WriteLine($"Starting speed: {CurrentSpeed}");
            if (FuelTank > 0)
                while (distance > 0)
                {
                    distance -= CurrentSpeed;
                    FuelTank -= _engine.Consumption;
                    Console.WriteLine($"\t Fuel left: {FuelTank}");
                    if (FuelTank <= 0)
                    {
                        Console.WriteLine("OUT OF FUEL");
                        break;
                    }
                    if (distance - distanceToAccelerate <= 0)
                    {
                        _engine.Decelerate();
                        CurrentSpeed = RPMToSpeed(_engine.RPM);
                        Console.WriteLine($"Decelerating to {CurrentSpeed}");
                    }
                    else if (_engine.RPM < 2000)
                    {
                        distanceToAccelerate += CurrentSpeed;
                        _engine.Accelerate();
                        CurrentSpeed = RPMToSpeed(_engine.RPM);
                        Console.WriteLine($"Accelerating to {CurrentSpeed}");
                    }
                    else
                    {
                        Console.WriteLine($"Maintaining speed {CurrentSpeed}");
                    }
                }
            _engine.TurnOff();
            Console.WriteLine("Turning off the engine");
        }

        public void DriveFast(int distance, float radioFrequency)
        {
            int distanceToAccelerate = 0;
            _engine.TurnOn();
            Console.WriteLine("Turning on the engine");
            _radio.TurnOn();
            Console.WriteLine("Turning on the radio");
            _radio.ChangeFrequency(radioFrequency);
            Console.WriteLine(_radio.NowPlaying());         
            CurrentSpeed = RPMToSpeed(_engine.RPM);
            Console.WriteLine($"Starting speed: {CurrentSpeed}");
            if (FuelTank > 0)
                while (distance > 0)
                {
                    distance -= CurrentSpeed;
                    FuelTank -= _engine.Consumption;
                    Console.WriteLine($"\t Fuel left: {FuelTank}");
                    if (FuelTank <= 0)
                    {
                        Console.WriteLine("OUT OF FUEL");
                        break;
                    }
                    if (distance - distanceToAccelerate <= 0)
                    {
                        _engine.Decelerate();
                        CurrentSpeed = RPMToSpeed(_engine.RPM);
                        Console.WriteLine($"Decelerating to {CurrentSpeed}");
                    }
                    else if(_engine.RPM != _engine.MaxRPM)
                    {
                        distanceToAccelerate += CurrentSpeed;
                        _engine.Accelerate();
                        CurrentSpeed = RPMToSpeed(_engine.RPM);
                        Console.WriteLine($"Accelerating to {CurrentSpeed}");
                    }
                    else
                    {
                        Console.WriteLine($"Maintaining speed {CurrentSpeed}");
                    }
                }
            _engine.TurnOff();
            Console.WriteLine("Turning off the engine");
            _radio.TurnOff();
            Console.WriteLine("Turning off the radio");
        }

        private int RPMToSpeed(int RPM)
        {
            return (int)Math.Round((float)RPM / 100 * 4);
        }
    }
}
