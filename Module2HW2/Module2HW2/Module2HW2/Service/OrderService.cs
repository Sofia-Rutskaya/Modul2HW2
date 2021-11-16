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
        private Device[] _device;
        private Random _rand;
        private StringBuilder _orders;

        public OrderService()
        {
            _notifications = new NotificationsService();
            _basketService = new BasketService();
            _rand = new Random();
            _orders = new StringBuilder();
        }

        public void ToOrder(string name, string placeOfResidence, int phoneNumber, string email)
        {
            var numberOfOrder = _rand.Next(10000);
            Console.WriteLine("Ваши товары в корзине:");
            AllDevicesInBasket();
            _orders.AppendLine($"{Environment.NewLine}Для оформления заказа введите свои данные:");
            _orders.AppendLine($"Имя: {name}");
            _orders.AppendLine($"Место жительства: {placeOfResidence}");
            _orders.AppendLine($"Номер телефона: {phoneNumber}");
            _orders.AppendLine($"Email: {email}");
            _orders.AppendLine($"Заказ #{numberOfOrder} на сумму {CountSumOfOrder()} {_device[0].Currency} принят.");

            Console.WriteLine(_orders);
            _notifications.Messages(numberOfOrder, name, placeOfResidence, phoneNumber, email, CountSumOfOrder());
        }

        public void AllDevicesInBasket()
        {
            _device = _basketService.GetBusketDevises();

            for (var i = 0; i < _device.Length; i++)
            {
                if (_device[i] != null)
                {
                    _orders.AppendLine($"#{_device[i].Id}Name: {_device[i].Name}  Model: {_device[i].Model}");
                    _orders.AppendLine($"Price: {_device[i].Price} {_device[i].Currency}");
                }
            }
        }

        public double CountSumOfOrder()
        {
            var counter = 0.0;
            for (var i = 0; i < _device.Length; i++)
            {
                if (_device[i] != null)
                {
                    counter += _device[i].Price;
                }
            }

            return counter;
        }
    }
}
