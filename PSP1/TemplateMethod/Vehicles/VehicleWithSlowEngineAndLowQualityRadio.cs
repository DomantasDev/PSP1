using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Engines;
using TemplateMethod.Radios;

namespace TemplateMethod.Vehicles
{
    public class VehicleWithSlowEngineAndLowQualityRadio : Vehicle
    {
        SlowEngine _engine = new SlowEngine();
        LowQualityRadio _radio = new LowQualityRadio();

        protected override int RPM { get => _engine.RPM; }
        protected override int MaxRPM { get => _engine.MaxRPM; }
        protected override float Consumption { get => _engine.Consumption; }
        protected override bool EngineIsOn { get => _engine.IsOn; }
        protected override bool RadioIsOn { get => _radio.IsOn; }
        protected override float Frequency { get => _radio.Frequency; }

        protected override void Accelerate()
        {
            _engine.Accelerate();
        }

        protected override void ChangeFrequency(float frequency)
        {
            _radio.ChangeFrequency(frequency);
        }

        protected override void Decelerate()
        {
            _engine.Decelerate();
        }

        protected override string NowPlaying()
        {
            return _radio.NowPlaying();
        }

        protected override void TurnOffEngine()
        {
            _engine.TurnOff();
        }

        protected override void TurnOffRadio()
        {
            _radio.TurnOff();
        }

        protected override void TurnOnEngine()
        {
            _engine.TurnOn();
        }

        protected override void TurnOnRadio()
        {
            _radio.TurnOn();
        }
    }
}
