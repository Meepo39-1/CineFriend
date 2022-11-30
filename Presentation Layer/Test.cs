using Domain.Rooms.Cinema;
using Domain.Rooms.Cinemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer
{
    internal class Test
    {

        public void CreateHolidayCinemaRoom()
        {
            Console.WriteLine("Happy Saint Andrew to everyone!");

            var cinemaRoom = new HolidayCinemaRoom();
            var holidayChay =cinemaRoom.CreateChat();
        }
    }
}
