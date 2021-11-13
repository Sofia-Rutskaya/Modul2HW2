using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Service;

namespace Module2HW2
{
    public class Starter
    {
        private ConfigService _config;
        private DeviceServise _deviceServise;
        private BasketService _basket;

        public Starter()
        {
            _config = new ConfigService();
            _deviceServise = new DeviceServise();
            _basket = new BasketService();
        }

        public void Run()
        {
            _deviceServise.GetAllDevices();
            _deviceServise.Print();
            Console.WriteLine("\n----------------------------------------\n");
            _basket.AddDevice(122);
            _basket.AddDevice(177);
            _basket.AddDevice(100);
            _basket.AddDevice(111);
            _basket.AddDevice(199);
            _basket.PrintDevices();
        }
    }
}
