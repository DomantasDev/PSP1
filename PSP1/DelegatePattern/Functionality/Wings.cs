using DelegatePattern.Functionality.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePattern.Functionality
{
    public class Wings : IWings
    {
        public void Fly(int distance)
        {
            Console.WriteLine("Flying distance of " + distance);
        }
    }
}
