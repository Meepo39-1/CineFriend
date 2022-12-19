using Application.Repositorys.Movies;
using Application.Repositorys.Rooms;
using Application.Repositorys.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositorys
{
    public interface IUnitOfWork : IDisposable
    {
        public IUserRepository UserRepository { get;  }
        public IMovieLibraryRepository MovieLibraryRepository { get;}
        public ICinemaRoomRepository CinemaRoomRepository { get; }
        public IMoviePlayerRepository MoviePlayerRepository { get; }
        public IChatRepository ChatRepository { get; }

        public Task<bool> BeginTransaction();
        public Task<bool> CommitTransaction();
        

        public Task Save();
    }
}
