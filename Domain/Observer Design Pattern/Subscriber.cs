using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Observer_Design_Pattern
{
    public interface Subscriber
    {
        
        public void Notify(string context);
    }
}
