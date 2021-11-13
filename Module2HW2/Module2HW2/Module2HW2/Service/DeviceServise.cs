using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Provider;

namespace Module2HW2.Service
{
    public class DeviceServise
    {
        private ConfigService _configService;
        private ShopDevices _shopDevices;
        private Device[] _device;

        public DeviceServise()
        {
            _configService = new ConfigService();
            _shopDevices = new ShopDevices();
        }

        public Device[] GetAllDevices()
        {
           _device = _shopDevices.GetShopDevices(_configService.GetCurrency());
           return _device;
        }

        public void Print()
        {
            for (var i = 0; i < _device.Length; i++)
            {
                _shopDevices.PrintDevices(i);
            }
        }
    }
}
