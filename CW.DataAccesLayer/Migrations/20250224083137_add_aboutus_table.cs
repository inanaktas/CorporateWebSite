using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class add_aboutus_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "UserInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutUs_UserInfos_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutUs_CreatedBy",
                table: "AboutUs",
                column: "CreatedBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "UserInfos");
        }
    }
}
