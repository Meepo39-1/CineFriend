using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rooms
{
    public class Chat
    {
       
        List<string> _messages;

        public List<string> Messages
        {
            get { return _messages; }
            set { _messages = value; }
        }

    }
}
