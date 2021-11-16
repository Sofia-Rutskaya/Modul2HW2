using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Service;

namespace Module2HW2.Provider
{
    public class Basket
    {
        private static readonly Basket _instance = new Basket();
        private Device[] _basket;
        private ConfigService _config;

        static Basket()
        {
        }

        private Basket()
        {
            _config = new ConfigService();
            _basket = new Device[_config.GetBusketSize()];
        }

        public static Basket Instance => _instance;

        public void AddItems(Device dev)
        {
            for (var i = 0; i < _basket.Length; i++)
            {
                if (_basket[i] == null)
                {
                    _basket[i] = dev;
                    break;
                }
            }
        }

        public Device[] GetBusketDevises()
        {
            return _basket;
        }
    }
}
