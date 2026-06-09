using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUserID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issue_AspNetUsers_UserID",
                table: "Issue");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Issue",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Issue_UserID",
                table: "Issue",
                newName: "IX_Issue_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Issue",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Issue_AspNetUsers_UserId",
                table: "Issue",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issue_AspNetUsers_UserId",
                table: "Issue");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Issue",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Issue_UserId",
                table: "Issue",
                newName: "IX_Issue_UserID");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Issue",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Issue_AspNetUsers_UserID",
                table: "Issue",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
