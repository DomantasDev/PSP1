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

        void DeriveEconomically(int distance)
        {
            int distanceToAccelerate = 0;
            _engine.TurnOn();
            CurrentSpeed = RPMToSpeed(_engine.RPM);
            if (FuelTank > 0)
                while (distance > 0)
                {
                    distance -= CurrentSpeed;
                    FuelTank -= _engine.Consumption;
                    if (FuelTank <= 0)
                    {
                        Console.WriteLine("OUT OF FUEL");
                        break;
                    }
                    if (distance - distanceToAccelerate <= 0)
                    {
                        _engine.Decelerate();
                    }
                    else if (_engine.RPM < 2000)
                    {
                        distanceToAccelerate += CurrentSpeed;
                        _engine.Accelerate();
                        CurrentSpeed = RPMToSpeed(_engine.RPM);
                    }
                }
            _engine.TurnOff();

        }

        void DriveFast(int distance, float radioFrequency)
        {
            int distanceToAccelerate = 0;
            _engine.TurnOn();
            _radio.TurnOn();
            _radio.ChangeFrequency(radioFrequency);
            Console.WriteLine(_radio.NowPlaying());
            CurrentSpeed = RPMToSpeed(_engine.RPM);
            if (FuelTank > 0)
                while (distance > 0)
                {
                    distance -= CurrentSpeed;
                    FuelTank -= _engine.Consumption;
                    if(FuelTank <= 0)
                    {
                        Console.WriteLine("OUT OF FUEL");
                        break;
                    }
                    if (distance - distanceToAccelerate <= 0)
                    {
                        _engine.Decelerate();
                    }
                    else
                    {
                        distanceToAccelerate += CurrentSpeed;
                        _engine.Accelerate();
                        CurrentSpeed = RPMToSpeed(_engine.RPM);
                    }
                }
            _engine.TurnOff();
            _radio.TurnOff();
        }

        private int RPMToSpeed(int RPM)
        {
            return (int)Math.Round((float)RPM / 100 * 4);
        }
    }
}
