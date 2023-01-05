using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddInviteTabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GuestCinemaRoomInvitation_CinemaRooms_CinemaRoomId",
                table: "GuestCinemaRoomInvitation");

            migrationBuilder.DropForeignKey(
                name: "FK_GuestCinemaRoomInvitation_Users_UserId",
                table: "GuestCinemaRoomInvitation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GuestCinemaRoomInvitation",
                table: "GuestCinemaRoomInvitation");

            migrationBuilder.RenameTable(
                name: "GuestCinemaRoomInvitation",
                newName: "Invitations");

            migrationBuilder.RenameIndex(
                name: "IX_GuestCinemaRoomInvitation_UserId",
                table: "Invitations",
                newName: "IX_Invitations_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invitations",
                table: "Invitations",
                columns: new[] { "CinemaRoomId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Invitations_CinemaRooms_CinemaRoomId",
                table: "Invitations",
                column: "CinemaRoomId",
                principalTable: "CinemaRooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invitations_Users_UserId",
                table: "Invitations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invitations_CinemaRooms_CinemaRoomId",
                table: "Invitations");

            migrationBuilder.DropForeignKey(
                name: "FK_Invitations_Users_UserId",
                table: "Invitations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invitations",
                table: "Invitations");

            migrationBuilder.RenameTable(
                name: "Invitations",
                newName: "GuestCinemaRoomInvitation");

            migrationBuilder.RenameIndex(
                name: "IX_Invitations_UserId",
                table: "GuestCinemaRoomInvitation",
                newName: "IX_GuestCinemaRoomInvitation_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GuestCinemaRoomInvitation",
                table: "GuestCinemaRoomInvitation",
                columns: new[] { "CinemaRoomId", "UserId" });

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
        }
    }
}
