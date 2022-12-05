using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Notification
{
    public class EmailDecorator : BaseNotificationDecorator
    {
        Notification wrapee;
        public EmailDecorator(Notification wrappe) : base(wrappe)
        {
        }
        public override void SendMessage()
        {
            Console.WriteLine("Sending message" + this.message + "through email");
            wrapee.SendMessage();
        }
    }
}
