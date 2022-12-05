using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Notification
{
    public class BaseNotificationDecorator : Notification
    {
        Notification wrappe;
        public BaseNotificationDecorator(string message) : base(message)
        {

        }
        public BaseNotificationDecorator(Notification wrappe) : base()
        {
            this.wrappe = wrappe;
        }

        public override void SendMessage()
        {   
            wrappe.SendMessage();
        }
    }
}
