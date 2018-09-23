using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IRadio
    {
        bool IsOn { get; }

        void TurnOn();
        void TurnOff();
        void ChangeFrequency(float frequency);
        string NowPlaying();
    }
}
