using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationDemo.Migrations
{
    public partial class UpdateNoteModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Notes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Notes");
        }
    }
}
