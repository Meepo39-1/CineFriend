using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SwappingInfraModelsWDomainModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CinemaRooms_Users_UserTypeId",
                table: "CinemaRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_GuestCinemaRoomInvitation_CinemaRooms_CinemaRoomTypeId",
                table: "GuestCinemaRoomInvitation");

            migrationBuilder.DropForeignKey(
                name: "FK_GuestCinemaRoomInvitation_Users_UserTypeId",
                table: "GuestCinemaRoomInvitation");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_ChatRooms_ChatId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieLibraries_Users_UserTypeId",
                table: "MovieLibraries");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviePlayers_CinemaRooms_CinemaRoomTypeId",
                table: "MoviePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieLibraries_MovieLibraryTypeId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "ChatRooms");

            migrationBuilder.RenameColumn(
                name: "MovieLibraryTypeId",
                table: "Movies",
                newName: "MovieLibraryId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_MovieLibraryTypeId",
                table: "Movies",
                newName: "IX_Movies_MovieLibraryId");

            migrationBuilder.RenameColumn(
                name: "CinemaRoomTypeId",
                table: "MoviePlayers",
                newName: "CinemaRoomId");

            migrationBuilder.RenameIndex(
                name: "IX_MoviePlayers_CinemaRoomTypeId",
                table: "MoviePlayers",
                newName: "IX_MoviePlayers_CinemaRoomId");

            migrationBuilder.RenameColumn(
                name: "UserTypeId",
                table: "MovieLibraries",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieLibraries_UserTypeId",
                table: "MovieLibraries",
                newName: "IX_MovieLibraries_UserId");

            migrationBuilder.RenameColumn(
                name: "UserTypeId",
                table: "GuestCinemaRoomInvitation",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CinemaRoomTypeId",
                table: "GuestCinemaRoomInvitation",
                newName: "CinemaRoomId");

            migrationBuilder.RenameIndex(
                name: "IX_GuestCinemaRoomInvitation_UserTypeId",
                table: "GuestCinemaRoomInvitation",
                newName: "IX_GuestCinemaRoomInvitation_UserId");

            migrationBuilder.RenameColumn(
                name: "UserTypeId",
                table: "CinemaRooms",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CinemaRooms_UserTypeId",
                table: "CinemaRooms",
                newName: "IX_CinemaRooms_UserId");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CinemaRoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_CinemaRooms_CinemaRoomId",
                        column: x => x.CinemaRoomId,
                        principalTable: "CinemaRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_CinemaRoomId",
                table: "Chats",
                column: "CinemaRoomId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CinemaRooms_Users_UserId",
                table: "CinemaRooms",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GuestCinemaRoomInvitation_CinemaRooms_CinemaRoomId",
                table: "GuestCinemaRoomInvitation",
                column: "CinemaRoomId",
                principalTable: "CinemaRooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GuestCinemaRoomInvitation_Users_UserId",
                table: "GuestCinemaRoomInvitation",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieLibraries_Users_UserId",
                table: "MovieLibraries",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviePlayers_CinemaRooms_CinemaRoomId",
                table: "MoviePlayers",
                column: "CinemaRoomId",
                principalTable: "CinemaRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieLibraries_MovieLibraryId",
                table: "Movies",
                column: "MovieLibraryId",
                principalTable: "MovieLibraries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CinemaRooms_Users_UserId",
                table: "CinemaRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_GuestCinemaRoomInvitation_CinemaRooms_CinemaRoomId",
                table: "GuestCinemaRoomInvitation");

            migrationBuilder.DropForeignKey(
                name: "FK_GuestCinemaRoomInvitation_Users_UserId",
                table: "GuestCinemaRoomInvitation");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieLibraries_Users_UserId",
                table: "MovieLibraries");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviePlayers_CinemaRooms_CinemaRoomId",
                table: "MoviePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieLibraries_MovieLibraryId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "MovieLibraryId",
                table: "Movies",
                newName: "MovieLibraryTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_MovieLibraryId",
                table: "Movies",
                newName: "IX_Movies_MovieLibraryTypeId");

            migrationBuilder.RenameColumn(
                name: "CinemaRoomId",
                table: "MoviePlayers",
                newName: "CinemaRoomTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MoviePlayers_CinemaRoomId",
                table: "MoviePlayers",
                newName: "IX_MoviePlayers_CinemaRoomTypeId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "MovieLibraries",
                newName: "UserTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieLibraries_UserId",
                table: "MovieLibraries",
                newName: "IX_MovieLibraries_UserTypeId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "GuestCinemaRoomInvitation",
                newName: "UserTypeId");

            migrationBuilder.RenameColumn(
                name: "CinemaRoomId",
                table: "GuestCinemaRoomInvitation",
                newName: "CinemaRoomTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_GuestCinemaRoomInvitation_UserId",
                table: "GuestCinemaRoomInvitation",
                newName: "IX_GuestCinemaRoomInvitation_UserTypeId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CinemaRooms",
                newName: "UserTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CinemaRooms_UserId",
                table: "CinemaRooms",
                newName: "IX_CinemaRooms_UserTypeId");

            migrationBuilder.CreateTable(
                name: "ChatRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CinemaRoomTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatRooms_CinemaRooms_CinemaRoomTypeId",
                        column: x => x.CinemaRoomTypeId,
                        principalTable: "CinemaRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatRooms_CinemaRoomTypeId",
                table: "ChatRooms",
                column: "CinemaRoomTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CinemaRooms_Users_UserTypeId",
                table: "CinemaRooms",
                column: "UserTypeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GuestCinemaRoomInvitation_CinemaRooms_CinemaRoomTypeId",
                table: "GuestCinemaRoomInvitation",
                column: "CinemaRoomTypeId",
                principalTable: "CinemaRooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GuestCinemaRoomInvitation_Users_UserTypeId",
                table: "GuestCinemaRoomInvitation",
                column: "UserTypeId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_ChatRooms_ChatId",
                table: "Messages",
                column: "ChatId",
                principalTable: "ChatRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieLibraries_Users_UserTypeId",
                table: "MovieLibraries",
                column: "UserTypeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviePlayers_CinemaRooms_CinemaRoomTypeId",
                table: "MoviePlayers",
                column: "CinemaRoomTypeId",
                principalTable: "CinemaRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieLibraries_MovieLibraryTypeId",
                table: "Movies",
                column: "MovieLibraryTypeId",
                principalTable: "MovieLibraries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
