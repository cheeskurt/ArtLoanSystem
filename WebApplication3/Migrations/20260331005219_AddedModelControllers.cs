using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class AddedModelControllers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Issue",
                columns: table => new
                {
                    IssueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateIssued = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateReturned = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDue = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issue", x => x.IssueID);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "ItemIssue",
                columns: table => new
                {
                    ItemIssueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Condition = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemIssue", x => x.ItemIssueID);
                    table.ForeignKey(
                        name: "FK_ItemIssue_Issue_IssueID",
                        column: x => x.IssueID,
                        principalTable: "Issue",
                        principalColumn: "IssueID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemIssue_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheStock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockID);
                    table.ForeignKey(
                        name: "FK_Stock_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemIssue_IssueID",
                table: "ItemIssue",
                column: "IssueID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemIssue_ItemID",
                table: "ItemIssue",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ItemID",
                table: "Stock",
                column: "ItemID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemIssue");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Issue");

            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
