using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePattern.Entities
{
    public class Car
    {
        public void Drive(int distance)
        {
            Console.WriteLine("Driving distance " + distance);
        }
    }
}
