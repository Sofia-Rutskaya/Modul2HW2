using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Service
{
    public class SmsMessageService
    {
        private ConfigService _config;
        public SmsMessageService()
        {
            _config = new ConfigService();
        }

        public void PrintMessage(int numberOfOrder, string name, string placeOfResidence, int phoneNumber, double sumOfOrder)
        {
            Console.WriteLine($"На ваш номер {phoneNumber} было отправлено уведомление о заказе.{Environment.NewLine}" +
                $"Вам отправлен заказ {numberOfOrder} на имя {name} по адресу {placeOfResidence}{Environment.NewLine}Общая сумма составляет {sumOfOrder} {_config.GetCurrency()}{Environment.NewLine}");
        }
    }
}
