using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNeedTickets.Migrations
{
    /// <inheritdoc />
    public partial class fixerror : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test",
                table: "AspNetUserRoles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "test",
                table: "AspNetUserRoles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
