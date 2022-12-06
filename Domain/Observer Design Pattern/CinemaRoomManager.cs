using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Observer_Design_Pattern
{
    public class CinemaRoomManager
    {
        List<User> guests;

        foreach(var user in guests){
                
            user.Notify();
    }
}
