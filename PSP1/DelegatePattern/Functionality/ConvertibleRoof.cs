using DelegatePattern.Functionality.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePattern.Functionality
{
    public class ConvertibleRoof :IConvertibleRoof
    {
        private bool _isOpened = false;

        public void OpenRoof()
        {
            if (!_isOpened)
            {
                Console.WriteLine("Opening roof");
                _isOpened = true;
            }
        }

        public void CloseRoof()
        {
            if (_isOpened)
            {
                Console.WriteLine("Closing roof");
                _isOpened = false;
            }
        }
    }
}
