﻿using Application.Repositorys;
using Application.Repositorys.Movies;
using Application.Repositorys.Rooms;
using Application.Repositorys.Users;
using Infrastructure.EntityFrameworkDataBase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EFRepositoryies
{
    public class UnitOfWork : IUnitOfWork
    {
        /*private ApplicationDbContext _dbContext;
        private EFCoreUserRepository _userRepository;
        private EFCoreCinemaRepository _cinemaRepository;*/
        private readonly DbContext _dbContext;
        private IDbContextTransaction _transactionContext;


        public UnitOfWork(ApplicationDbContext dbContext, IUserRepository userRepository, ICinemaRoomRepository cinemaRepository,
            IMoviePlayerRepository moviePlayerRepository, IChatRepository chatRepository, IMovieLibraryRepository movieLibraryRepository, IMessageRepository messageRepository)
        {
            _dbContext = dbContext;
             UserRepository = userRepository;
            CinemaRoomRepository = cinemaRepository;
            MovieLibraryRepository = movieLibraryRepository;
            ChatRepository = chatRepository;
            MoviePlayerRepository = moviePlayerRepository;
            MessageRepository = messageRepository;
        }

        public IUserRepository UserRepository { get; private set; }
        public IMessageRepository MessageRepository { get; private set; }

        public ICinemaRoomRepository CinemaRoomRepository { get; private set; }

        public IMovieLibraryRepository MovieLibraryRepository { get; private set; }

        public IMoviePlayerRepository MoviePlayerRepository { get; private set; }
        public IChatRepository ChatRepository { get; private set; }

        public IMovieRepository MovieRepository => throw new NotImplementedException();

        public Task<bool> BeginTransaction()
        {
            try
            {
                _transactionContext = _dbContext.Database.BeginTransaction();
                return Task.FromResult(true);
            }
            catch(Exception ex)
            {
                return Task.FromResult(false);
            }
        }

        public Task<bool> CommitTransaction()
        {
            try
            {
                _transactionContext.Commit();
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                return Task.FromResult(false);
            }
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public async Task Save()
        {  
            await _dbContext.SaveChangesAsync();
        }
    }
}


