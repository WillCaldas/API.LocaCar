using Microsoft.EntityFrameworkCore.Migrations;

namespace API.LocaCar.Migrations
{
    public partial class updateEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Enderecos",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Enderecos");
        }
    }
}
