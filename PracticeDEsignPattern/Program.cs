using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDEsignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationFactory emailFactory = new EmailNotificationFactory();
            NotificationFactory smsFactory = new SMSNotificationFactory();

            NotificationService notificationService = new NotificationService(emailFactory);
            notificationService.SendNotification();
            
        }
    }
}
