using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Radios
{
    public class HighQualityRadio : IRadio
    {
        float _frequency;

        public bool IsOn { get; private set; }

        public void ChangeFrequency(float frequency)
        {
            _frequency = frequency;
        }

        public string NowPlaying()
        {
            return $"Listening to {_frequency} FM, on HIGH quality radio";
        }

        public void TurnOff()
        {
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
        }
    }
}
