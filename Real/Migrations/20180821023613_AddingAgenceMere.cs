using Microsoft.EntityFrameworkCore.Migrations;

namespace Real.Migrations
{
    public partial class AddingAgenceMere : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ville",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ville",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32);
        }
    }
}
