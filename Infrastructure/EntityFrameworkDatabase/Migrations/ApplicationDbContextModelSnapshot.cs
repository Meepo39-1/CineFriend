﻿// <auto-generated />
using System;
using Infrastructure.EntityFrameworkDataBase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Movies.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Length")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MovieLibraryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieLibraryId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Domain.Movies.MovieLibrary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("MovieLibraries");
                });

            modelBuilder.Entity("Domain.Movies.MoviePlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CinemaRoomId")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CinemaRoomId")
                        .IsUnique();

                    b.ToTable("MoviePlayers");
                });

            modelBuilder.Entity("Domain.Rooms.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CinemaRoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CinemaRoomId")
                        .IsUnique();

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Domain.Rooms.CinemaRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("CinemaRooms");
                });

            modelBuilder.Entity("Domain.Rooms.GuestCinemaRoomInvitation", b =>
                {
                    b.Property<int?>("CinemaRoomId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CinemaRoomId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("GuestCinemaRoomInvitation");
                });

            modelBuilder.Entity("Domain.Rooms.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChatId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Domain.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Movies.Movie", b =>
                {
                    b.HasOne("Domain.Movies.MovieLibrary", "MovieLibrary")
                        .WithMany("Movies")
                        .HasForeignKey("MovieLibraryId");

                    b.Navigation("MovieLibrary");
                });

            modelBuilder.Entity("Domain.Movies.MovieLibrary", b =>
                {
                    b.HasOne("Domain.Users.User", "User")
                        .WithOne("MovieLibrary")
                        .HasForeignKey("Domain.Movies.MovieLibrary", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Movies.MoviePlayer", b =>
                {
                    b.HasOne("Domain.Rooms.CinemaRoom", "CinemaRoom")
                        .WithOne("MoviePlayer")
                        .HasForeignKey("Domain.Movies.MoviePlayer", "CinemaRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CinemaRoom");
                });

            modelBuilder.Entity("Domain.Rooms.Chat", b =>
                {
                    b.HasOne("Domain.Rooms.CinemaRoom", "CinemaRoom")
                        .WithOne("Chat")
                        .HasForeignKey("Domain.Rooms.Chat", "CinemaRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CinemaRoom");
                });

            modelBuilder.Entity("Domain.Rooms.CinemaRoom", b =>
                {
                    b.HasOne("Domain.Users.User", "Admin")
                        .WithOne("AdminCinema")
                        .HasForeignKey("Domain.Rooms.CinemaRoom", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("Domain.Rooms.GuestCinemaRoomInvitation", b =>
                {
                    b.HasOne("Domain.Rooms.CinemaRoom", "CinemaRoom")
                        .WithMany("Guests")
                        .HasForeignKey("CinemaRoomId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Domain.Users.User", "User")
                        .WithMany("guestCinemas")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("CinemaRoom");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Rooms.Message", b =>
                {
                    b.HasOne("Domain.Rooms.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");
                });

            modelBuilder.Entity("Domain.Movies.MovieLibrary", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Domain.Rooms.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Domain.Rooms.CinemaRoom", b =>
                {
                    b.Navigation("Chat")
                        .IsRequired();

                    b.Navigation("Guests");

                    b.Navigation("MoviePlayer")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Users.User", b =>
                {
                    b.Navigation("AdminCinema")
                        .IsRequired();

                    b.Navigation("MovieLibrary")
                        .IsRequired();

                    b.Navigation("guestCinemas");
                });
#pragma warning restore 612, 618
        }
    }
}
