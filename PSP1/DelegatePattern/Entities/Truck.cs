using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePattern.Entities
{
    public class Truck
    {
        public void TransportCargo(int distance, int weight)
        {
            Console.WriteLine("Transporting cargo of weight " + weight + ". Distance " + distance);
        }
    }
}
