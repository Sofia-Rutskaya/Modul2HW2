using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Service
{
    public class SmsMessageService
    {
        public void PrintMessage(int a, UserService user)
        {
            Console.WriteLine($"\n\nНа ваш номер {user.TelNumber} было отправлено уведомление о заказе.\n" +
                $"Вам отправлен заказ {a}\n на имя {user.Name} {user.LastName}\n по адресу {user.PlaceOfResidence}");
        }
    }
}
