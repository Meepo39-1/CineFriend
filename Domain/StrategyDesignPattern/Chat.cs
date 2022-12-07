using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.StrategyDesignPattern
{
    public class Chat : CommunicationMedium
    {
      
        public void Write(MessageInfo message)
        {
            Console.WriteLine("Writing" + message + "to chat");
        }

        public void Display(MessageInfo message)
        {
            Write(message);
        }
    }
}
