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
        private NotificationsService _notifications;
        private Random _rand;

        public OrderService()
        {
            _notifications = new NotificationsService();
            _basketService = new BasketService();
            _rand = new Random();
        }

        public void ToOrder()
        {
            Console.WriteLine("Ваши товары в корзине:\n");
            _basketService.PrintDevices();
            Console.WriteLine("Для оформления заказа введите свои данные:\n");
        }

        public void FinishOrder(UserService user)
        {
            Console.WriteLine("Ваш заказ принят, ожидайте.\n");
            _notifications.Messages(123456777, user);
        }
    }
}
