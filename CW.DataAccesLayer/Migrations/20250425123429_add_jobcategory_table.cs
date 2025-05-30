using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class add_jobcategory_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobCategoryId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_JobCategoryId",
                table: "Applications",
                column: "JobCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_JobCategories_JobCategoryId",
                table: "Applications",
                column: "JobCategoryId",
                principalTable: "JobCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_JobCategories_JobCategoryId",
                table: "Applications");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropIndex(
                name: "IX_Applications_JobCategoryId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "JobCategoryId",
                table: "Applications");
        }
    }
}
