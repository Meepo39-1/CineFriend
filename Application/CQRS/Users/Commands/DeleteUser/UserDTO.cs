using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Users.Commands.DeleteUser
{
    public class UserDTO
    {
        string ID { get; }
        string Name { get; };
    }
}
