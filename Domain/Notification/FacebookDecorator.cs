using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Notification
{
    public class FacebookDecorator : BaseNotificationDecorator
    {
        Notification wrapee;
        public FacebookDecorator(Notification wrappe) : base(wrappe)
        {
        }
        public override void SendMessage()
        {
            Console.WriteLine("Sending message" + message + "through facebook");
            wrapee.SendMessage();
        }
    }
}
