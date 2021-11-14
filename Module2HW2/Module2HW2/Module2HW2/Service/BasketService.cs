using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Provider;

namespace Module2HW2.Service
{
    public class BasketService
    {
        private ConfigService _configService;
        private Basket _basket;
        private Device[] _device;
        private DeviceServise _dev;

        public BasketService()
        {
            _configService = new ConfigService();
            _basket = Basket.Instance;
            _dev = new DeviceServise();
            _device = _dev.GetAllDevices();
        }

        public void AddDevice(int id)
        {
            for (var i = 0; i < _device.Length; i++)
            {
                if (id == _device[i].ID)
                {
                    _basket.AddItems(_device[i]);
                    break;
                }
            }
        }

        public void PrintDevices()
        {
            for (var i = 0; i < _configService.GetBusketSize(); i++)
            {
                _basket.PrintBasket(i);
            }
        }
    }
}
