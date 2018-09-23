using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Engines
{
    public interface IEngine
    {
        int RPM { get; }
        float Consumption { get; }
        bool IsOn { get; }

        void TurnOn();
        void TurnOff();
        void Accelerate();
        void Decelerate();
    }
}
