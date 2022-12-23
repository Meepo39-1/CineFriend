using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rooms
{
    public class Chat
    {
        public int Id { get; set; }
        List<Message> _messages;

        public List<Message> Messages
        {
            get { return _messages; }
            set { _messages = value; }
        }

    }
}
