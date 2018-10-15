using DelegatePattern.Functionality.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePattern.Functionality 
{
    public class Radio : IRadio
    {
        public void ListenToMusic(float frequency)
        {
            Console.WriteLine("Listening to music on " + frequency + "MHz");
        }
    }
}
