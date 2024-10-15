using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDEsignPattern
{
    public class NotificationService
    {
        public readonly NotificationFactory _factory;
        public NotificationService(NotificationFactory factory)
        {
            _factory = factory;
        }
        public void SendNotification()
        {
            INotification notification = _factory.CreateNotification();
            notification.Notify();
        }

        //public void SendNotification(string type)
        //{
        //    INotification notification;
        //    switch (type) 
        //    {
        //        case "SMS":
        //            notification = new SMSNotification();
        //            break;
        //        case "Email":
        //            notification = new EmailNotification();
        //            break;
        //        default:
        //            throw new NotSupportedException();

        //    }
        //    notification.Notify();
        
    }
}
