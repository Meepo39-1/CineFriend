using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public Task<List<GuestCinemaRoomInvitation>> GetInvites(int userId)
        {
           var listInvites =  _dbContext.Invitations
           .Where(i => i.UserId == userId 
           &&
           i.ExpirationDate.CompareTo(DateTimeOffset.Now)>0
           &&
           ( i.Status.Equals("accepted") || i.Status.Equals("pending")))
           .ToList();


            return Task.FromResult(listInvites);
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
