using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMS.Desafio.Telemedicina.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Enabledfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "Registrations",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "Registrations");
        }
    }
}
