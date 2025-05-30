using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class base_model_changed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CreatedBy",
                table: "Projects",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_UserInfos_CreatedBy",
                table: "Projects",
                column: "CreatedBy",
                principalTable: "UserInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_UserInfos_CreatedBy",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_CreatedBy",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Projects");
        }
    }
}
