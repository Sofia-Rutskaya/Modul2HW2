using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Provider;

namespace Module2HW2.Service
{
    public class OrderService
    {
        private BasketService _basketService;

        public OrderService()
        {
            _basketService = new BasketService();
        }

        public void ToOrder()
        {
            Console.WriteLine("Ваши товары в корзине:\n");
            _basketService.PrintDevices();
            Console.WriteLine("Для оформления заказа введите свои данные:\n");
        }

        public void FinishOrder()
        {
            Console.WriteLine("Ваш заказ принят, ожидайте.\n");
        }
    }
}
