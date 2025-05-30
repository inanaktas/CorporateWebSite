using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class update_feedback_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPending",
                table: "Feedbacks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "Feedbacks",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPending",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "Feedbacks");
        }
    }
}
