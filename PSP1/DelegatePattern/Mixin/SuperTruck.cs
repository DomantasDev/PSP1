using DelegatePattern.Entities;
using DelegatePattern.Functionality;
using DelegatePattern.Functionality.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePattern.Mixin
{
    public class SuperTruck : Truck, IWings, IRadio, IConvertibleRoof
    {
        ConvertibleRoof _roof = new ConvertibleRoof();
        Radio _radio = new Radio();
        Wings _wings = new Wings();

        public void OpenRoof()
        {
            _roof.OpenRoof();
        }

        public void CloseRoof()
        {
            _roof.CloseRoof();
        }

        public void ListenToMusic(float frequency)
        {
            _radio.ListenToMusic(frequency);
        }

        public void Fly(int distance)
        {
            _wings.Fly(distance);
        }
    }
}
