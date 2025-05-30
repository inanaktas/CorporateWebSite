using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class add_email_for_application_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Applications");
        }
    }
}
