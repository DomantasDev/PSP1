using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Radios
{
    public class HighQualityRadio
    {
        public float Frequency { get; private set; }

        public bool IsOn { get; private set; }

        public void ChangeFrequency(float frequency)
        {
            Frequency = frequency;
        }

        public string NowPlaying()
        {
            return $"Listening to {Frequency} FM, on HIGH quality radio";
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
