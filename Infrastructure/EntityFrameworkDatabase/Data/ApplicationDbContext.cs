using Domain.Movies;
using Infrastructure.EntityFrameworkDatabase.Models.Rooms;
using Infrastructure.EntityFrameworkDatabase.Models.Users;
using Infrastructure.EntityFrameworkDatabase.Models.Movies;
using Microsoft.EntityFrameworkCore;
using System;
using MovieLibrary = Infrastructure.EntityFrameworkDatabase.Models.Movies.MovieLibraryType;
using MoviePlayerType = Infrastructure.EntityFrameworkDatabase.Models.Movies.MoviePlayerType;

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
        public DbSet<UserType> Users { get; set; }

        //MovieRelatedTables
        public DbSet<MovieLibraryType> MovieLibraries { get; set; }
        public DbSet<MoviePlayerType> MoviePlayers { get; set; }
        public DbSet<MovieType> Movies { get; set; }

        //Chat related tables
        public DbSet<MessageType> Messages { get; set; }

        //Room related tables
        public DbSet<CinemaRoomType> CinemaRooms { get; set; }
        public DbSet<ChatRoomType> ChatRooms { get; set; }
      protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuestCinemaRoomInvitation>()
                .HasKey(t => new { t.CinemaRoomTypeId, t.UserTypeId });

            modelBuilder.Entity<GuestCinemaRoomInvitation>()
                .HasOne(pt => pt.User)
                .WithMany(p => p.guestCinemas)
                .HasForeignKey(pt => pt.UserTypeId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired(false);


            modelBuilder.Entity<GuestCinemaRoomInvitation>()
                .HasOne(pt => pt.CinemaRoom)
                .WithMany(t => t.Guests)
                .HasForeignKey(pt => pt.CinemaRoomTypeId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired(false);
               

        }
      
    }
}
