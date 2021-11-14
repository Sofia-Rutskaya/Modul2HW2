using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Service
{
    public class NotificationsService
    {
        private SmsMessageService _smsMessage;
        private EmailMessageService _emailMessage;

        public NotificationsService()
        {
            _smsMessage = new SmsMessageService();
            _emailMessage = new EmailMessageService();
        }

        public void Messages(int i, UserService user)
        {
            _smsMessage.PrintMessage(i, user);
            _emailMessage.PrintMessage(i, user);
        }
    }
}
