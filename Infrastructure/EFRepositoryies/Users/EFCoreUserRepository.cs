using Application.Repositorys.Users;
using Domain.Movies;
using Domain.Users;
using Infrastructure.EntityFrameworkDatabase.Models.Users;
using Infrastructure.EntityFrameworkDataBase.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EFRepositoryies.Users
{
    public class EFCoreUserRepository : IUserRepository
    {
        private ApplicationDbContext _dbContext;

        public EFCoreUserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<bool> DeleteUser(int userID)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(string userID)
        {
            throw new NotImplementedException();
        }

        /*   async Task<User> GetUser(int userID)
           {
               var userRecord = _dbContext.Users.First(u => u.Id == userID);
               var domainUser = new User();
               domainUser.Id = userRecord.Id;
               domainUser.Name = userRecord.Name;
               domainUser.Password = userRecord.Password;

               return domainUser;
           }
        */
        public Task<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }

        async Task<int> IUserRepository.CreateUser(User newUser)
        {
            var newUserRecord = new UserType();

            //mapping values from domain model to ef core model 
            newUserRecord.Name = newUser.Name;
            newUserRecord.Password = newUser.Password;


            // await _dbContext.AddAsync(newUserRecord);
            _dbContext.Add(newUserRecord);
            _dbContext.SaveChanges();
            // _dbContext.SaveChanges();
         //   _dbContext.SaveChanges();

            //remapping values from userRecord to domainUser
            /* var newDomainUser = new User();
             newDomainUser.Name = newUserRecord.Name;
             newDomainUser.Password = newUserRecord.Password;
             newDomainUser.Id = newUserRecord.Id;

             return newDomainUser;*/

           //returning temporary id
            return newUserRecord.Id;


        }

       /* Task<bool> IUserRepository.UpdateUser(int userID)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUserRepository.UpdateUser(string userID, List<string> changes)
        {
            throw new NotImplementedException();
        }*/

        Task<User> IUserRepository.GetUser(int userID)
        {
            var userRecord = _dbContext.Users.First(u => u.Id == userID);
            var domainUser = new User();
            domainUser.Id = userRecord.Id;
            domainUser.Name = userRecord.Name;
            domainUser.Password = userRecord.Password;

            return Task.FromResult(domainUser);
        }
    }
}
