using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rooms
{
    public class Message
    {
        public int Id { get; set; }

        public string Sender { get; set; }
        public DateTime DateTime { get; set; }
        public string Content { get; set; }
        public int ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}
