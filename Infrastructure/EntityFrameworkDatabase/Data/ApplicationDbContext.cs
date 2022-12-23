using Domain.Movies;
using Infrastructure.EntityFrameworkDatabase.Models.Rooms;
using Infrastructure.EntityFrameworkDatabase.Models.Users;
using Infrastructure.EntityFrameworkDatabase.Models.Movies;
using Microsoft.EntityFrameworkCore;
using System;
using Domain.Users;
using Domain.Rooms;
using GuestCinemaRoomInvitation = Domain.Rooms.GuestCinemaRoomInvitation;

namespace Infrastructure.EntityFrameworkDataBase.Data
{
    public class ApplicationDbContext : DbContext 
    {
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = BazaDeDateProiectEdi; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }
        


        //User related tables
        public DbSet<User> Users { get; set; }

        //MovieRelatedTables
        public DbSet<MovieLibrary> MovieLibraries { get; set; }
        public DbSet<MoviePlayer> MoviePlayers { get; set; }
        public DbSet<Movie> Movies { get; set; }

        //Chat related tables
        public DbSet<Message> Messages { get; set; }

        //Room related tables
        public DbSet<CinemaRoom> CinemaRooms { get; set; }
        public DbSet<Chat> Chats { get; set; }
      protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuestCinemaRoomInvitation>()
                .HasKey(t => new { t.CinemaRoomId, t.UserId });

            modelBuilder.Entity<GuestCinemaRoomInvitation>()
                .HasOne(pt => pt.User)
                .WithMany(p => p.guestCinemas)
                .HasForeignKey(pt => pt.UserId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired(false);


            modelBuilder.Entity<GuestCinemaRoomInvitation>()
                .HasOne(pt => pt.CinemaRoom)
                .WithMany(t => t.Guests)
                .HasForeignKey(pt => pt.CinemaRoomId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired(false);
               

        }
      
    }
}
