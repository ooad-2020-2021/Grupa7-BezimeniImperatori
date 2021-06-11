using Microsoft.EntityFrameworkCore.Migrations;

namespace JAWS.Migrations
{
    public partial class Cjenovnik_ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CjenovnikId",
                table: "CjenovnikItem",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CjenovnikId",
                table: "CjenovnikItem");
        }
    }
}
