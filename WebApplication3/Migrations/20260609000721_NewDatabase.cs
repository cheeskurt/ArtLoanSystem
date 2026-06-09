using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class NewDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemIssue_Item_ItemID",
                table: "ItemIssue");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "ItemIssue");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "ItemIssue");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "DateReturned",
                table: "Issue");

            migrationBuilder.RenameColumn(
                name: "Class",
                table: "Student",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "ItemID",
                table: "ItemIssue",
                newName: "StockID");

            migrationBuilder.RenameIndex(
                name: "IX_ItemIssue_ItemID",
                table: "ItemIssue",
                newName: "IX_ItemIssue_StockID");

            migrationBuilder.RenameColumn(
                name: "TheItem",
                table: "Item",
                newName: "ItemName");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StockTag",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "ItemIssue",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReturned",
                table: "ItemIssue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "Issue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "Issue",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Issue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubjectID",
                table: "Issue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Issue",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SubjectID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeacherCode",
                table: "AspNetUsers",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Issue_StudentID",
                table: "Issue",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Issue_SubjectID",
                table: "Issue",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Issue_UserID",
                table: "Issue",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SubjectID",
                table: "AspNetUsers",
                column: "SubjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Subject_SubjectID",
                table: "AspNetUsers",
                column: "SubjectID",
                principalTable: "Subject",
                principalColumn: "SubjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_Issue_AspNetUsers_UserID",
                table: "Issue",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Issue_Student_StudentID",
                table: "Issue",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Issue_Subject_SubjectID",
                table: "Issue",
                column: "SubjectID",
                principalTable: "Subject",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemIssue_Stock_StockID",
                table: "ItemIssue",
                column: "StockID",
                principalTable: "Stock",
                principalColumn: "StockID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Subject_SubjectID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Issue_AspNetUsers_UserID",
                table: "Issue");

            migrationBuilder.DropForeignKey(
                name: "FK_Issue_Student_StudentID",
                table: "Issue");

            migrationBuilder.DropForeignKey(
                name: "FK_Issue_Subject_SubjectID",
                table: "Issue");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemIssue_Stock_StockID",
                table: "ItemIssue");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Issue_StudentID",
                table: "Issue");

            migrationBuilder.DropIndex(
                name: "IX_Issue_SubjectID",
                table: "Issue");

            migrationBuilder.DropIndex(
                name: "IX_Issue_UserID",
                table: "Issue");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SubjectID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StockTag",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DateReturned",
                table: "ItemIssue");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "Issue");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "Issue");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Issue");

            migrationBuilder.DropColumn(
                name: "SubjectID",
                table: "Issue");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Issue");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SubjectID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TeacherCode",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Student",
                newName: "Class");

            migrationBuilder.RenameColumn(
                name: "StockID",
                table: "ItemIssue",
                newName: "ItemID");

            migrationBuilder.RenameIndex(
                name: "IX_ItemIssue_StockID",
                table: "ItemIssue",
                newName: "IX_ItemIssue_ItemID");

            migrationBuilder.RenameColumn(
                name: "ItemName",
                table: "Item",
                newName: "TheItem");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "ItemIssue",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "ItemIssue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Condition",
                table: "ItemIssue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReturned",
                table: "Issue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_ItemIssue_Item_ItemID",
                table: "ItemIssue",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
