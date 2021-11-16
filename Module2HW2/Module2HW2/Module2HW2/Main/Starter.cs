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
        private OrderService _orderService;

        public Starter()
        {
            _orderService = new OrderService();
            _config = new ConfigService();
            _deviceServise = new DeviceServise();
            _basket = new BasketService();
        }

        public void Run()
        {
            _basket.AddDevice(122);
            _basket.AddDevice(177);
            _basket.AddDevice(100);
            _basket.AddDevice(111);
            _basket.AddDevice(199);

            _orderService.ToOrder("София", "Донецька обл., Вул. Вільна 14/10", 1234567890, "email@gmail.ua");
        }
    }
}
