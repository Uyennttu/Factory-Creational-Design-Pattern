using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDEsignPattern
{
    public class SMSNotification : INotification
    {
        public void Notify() { Console.WriteLine("Sending SMS Notofication"); }
    }
}
