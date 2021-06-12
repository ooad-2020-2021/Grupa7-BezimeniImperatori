using Microsoft.EntityFrameworkCore.Migrations;

namespace JAWS.Migrations
{
    public partial class Promjena_Pacijent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Spol",
                table: "Korisnik",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Spol",
                table: "Korisnik",
                type: "nvarchar(1)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
