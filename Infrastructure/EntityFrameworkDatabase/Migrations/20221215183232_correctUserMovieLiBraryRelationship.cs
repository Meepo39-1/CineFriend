using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class correctUserMovieLiBraryRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoviePlayers_CinemaRooms_CinemaRoomId",
                table: "MoviePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_MovieLibraries_MovieLibraryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_MovieLibraryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MovieLibraryId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "CinemaRoomId",
                table: "MoviePlayers",
                newName: "CinemaRoomTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MoviePlayers_CinemaRoomId",
                table: "MoviePlayers",
                newName: "IX_MoviePlayers_CinemaRoomTypeId");

            migrationBuilder.AddColumn<int>(
                name: "UserTypeId",
                table: "MovieLibraries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MovieLibraries_UserTypeId",
                table: "MovieLibraries",
                column: "UserTypeId",
                unique: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieLibraries_Users_UserTypeId",
                table: "MovieLibraries");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviePlayers_CinemaRooms_CinemaRoomTypeId",
                table: "MoviePlayers");

            migrationBuilder.DropIndex(
                name: "IX_MovieLibraries_UserTypeId",
                table: "MovieLibraries");

            migrationBuilder.DropColumn(
                name: "UserTypeId",
                table: "MovieLibraries");

            migrationBuilder.RenameColumn(
                name: "CinemaRoomTypeId",
                table: "MoviePlayers",
                newName: "CinemaRoomId");

            migrationBuilder.RenameIndex(
                name: "IX_MoviePlayers_CinemaRoomTypeId",
                table: "MoviePlayers",
                newName: "IX_MoviePlayers_CinemaRoomId");

            migrationBuilder.AddColumn<int>(
                name: "MovieLibraryId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_MovieLibraryId",
                table: "Users",
                column: "MovieLibraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MoviePlayers_CinemaRooms_CinemaRoomId",
                table: "MoviePlayers",
                column: "CinemaRoomId",
                principalTable: "CinemaRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_MovieLibraries_MovieLibraryId",
                table: "Users",
                column: "MovieLibraryId",
                principalTable: "MovieLibraries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
