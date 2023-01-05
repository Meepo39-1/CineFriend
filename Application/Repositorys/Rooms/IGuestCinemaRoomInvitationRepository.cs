using Domain.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys.Rooms
{
    public interface IGuestCinemaRoomInvitationRepository
    {
        public Task<bool> CreateInvite(GuestCinemaRoomInvitation invitation);

        public Task<bool> UpdateInvite(int id, string status);

        public Task DeleteExpiredInvitations();

    }
}
