using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rooms
{
    internal class Chat
    {
        List<string> _messages;

        List<string> Messages
        {
            get { return _messages; }
            set { _messages = value; }
        }

    }
}
