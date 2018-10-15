using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePattern.Entities
{
    public class Crane
    {
        public void ListCargo(int height)
        {
            Console.WriteLine("Lifting cargo into height of " + height);
        }
    }
}
