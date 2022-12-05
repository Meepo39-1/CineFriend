using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Notification
{
    public abstract class Notification
    {
        protected string message;
        
        public Notification(string message)
        {
            this.message = message;
        }
        public Notification()
        {
            this.message = "";
        }
        public virtual void SendMessage()
        {
            Console.WriteLine("Sending message: " + this.message);
        }
        
       
    }
}
