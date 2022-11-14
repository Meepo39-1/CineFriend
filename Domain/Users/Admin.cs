using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    internal class Admin : User
    {

       

        public override User Clone()
        {
            return new Admin();
        }
    }
}
