using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Engines;

namespace TemplateMethod.Cranes
{
    public class CraneWithSlowEngine : Crane
    {
        SlowEngine _engine = new SlowEngine();

        protected override int RPM { get => _engine.RPM; }
        protected override int MaxRPM { get => _engine.MaxRPM; }
        protected override float Consumption { get => _engine.Consumption; }
        protected override bool EngineIsOn { get => _engine.IsOn; }

        protected override void Accelerate()
        {
            _engine.Accelerate();
        }

        protected override void Decelerate()
        {
            _engine.Decelerate();
        }

        protected override void TurnOffEngine()
        {
            _engine.TurnOff();
        }

        protected override void TurnOnEngine()
        {
            _engine.TurnOn();
        }
    }
}
