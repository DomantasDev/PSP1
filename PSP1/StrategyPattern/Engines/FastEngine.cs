using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Engines
{
    public class FastEngine : IEngine
    {
        public int RPM { get; private set; }

        float _idleConsumption = 10;
        float _consumption;
        public float Consumption { get => IsOn ? _consumption : 0; }

        public bool IsOn { get; private set; }

        private int[] _RPMs = new int[] {1000, 1500, 2000, 2500, 3000, 3500};
        private int _RPMIndex = 0;
        public void Accelerate()
        {
            if(IsOn && _RPMIndex < _RPMs.Length - 1)
            {
                RPM = _RPMs[_RPMIndex++];
                _consumption = _idleConsumption * RPM / 1000;
            }
        }

        public void Decelerate()
        {
            if (IsOn && _RPMIndex > 0 )
            {
                RPM = _RPMs[_RPMIndex--];
                _consumption = _idleConsumption * RPM / 1000;
            }
        }

        public void TurnOff()
        {
            if(IsOn)
            {
                IsOn = false;
                RPM = 0;
            }
        }

        public void TurnOn()
        {
            if (!IsOn)
            {
                IsOn = true;
                RPM = _RPMs[0];
                _consumption = _idleConsumption;
            }
        }
    }
}
