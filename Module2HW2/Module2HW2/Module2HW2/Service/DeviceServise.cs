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
        private AllDevicesInShop _shopDevices;
        private Device[] _device;

        public DeviceServise()
        {
            _configService = new ConfigService();
            _shopDevices = new AllDevicesInShop();
        }

        public Device[] GetAllDevices()
        {
            _device = _shopDevices.GetShopDevices(_configService.GetCurrency());

            for (var i = 0; i < _device.Length; i++)
            {
                switch (_configService.GetCurrency())
                {
                    case Currency.UAN:
                        break;
                    case Currency.RUB:
                        _device[i].Price *= 2.74770;
                        break;
                    case Currency.USD:
                        _device[i].Price *= 0.03772;
                        break;
                    case Currency.EUR:
                        _device[i].Price *= 0.03296;
                        break;
                }
            }

            return _device;
        }
    }
}
