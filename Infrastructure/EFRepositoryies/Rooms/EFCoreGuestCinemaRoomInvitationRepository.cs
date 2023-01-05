using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Repositorys.Rooms;
using Domain.Rooms;
using Infrastructure.EntityFrameworkDataBase.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EFRepositoryies.Rooms
{
    public class EFCoreGuestCinemaRoomInvitationRepository : IGuestCinemaRoomInvitationRepository
    {
        private readonly ApplicationDbContext _dbContext;
        
        public EFCoreGuestCinemaRoomInvitationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<bool> CreateInvite(GuestCinemaRoomInvitation invitation)
        {
            _dbContext.Invitations.Add(invitation);

            _dbContext.SaveChanges();

            return Task.FromResult(true);
        }

        public Task DeleteExpiredInvitations()
        {
            var expiredInvitations = _dbContext.Invitations.Where(i => i.Status == "pending" && i.ExpirationDate.CompareTo(DateTimeOffset.UtcNow) < 0);
            _dbContext.Invitations.BulkDelete(expiredInvitations);

                return Task.CompletedTask;
         }

        public Task<bool> UpdateInvite(int id, string status)
        {
            GuestCinemaRoomInvitation requestedInvite = _dbContext.Invitations.First(i => i.Id == id);

            requestedInvite.Status = status;
            _dbContext.Invitations.Update(requestedInvite);

            _dbContext.SaveChanges();

            return Task.FromResult(true);
        }
    }
}
