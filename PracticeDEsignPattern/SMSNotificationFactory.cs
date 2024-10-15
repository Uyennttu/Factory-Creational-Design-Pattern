﻿namespace PracticeDEsignPattern
{
    public class SMSNotificationFactory :NotificationFactory
    {
        public override INotification CreateNotification()
    {
        return new SMSNotification();
    }
}
}
