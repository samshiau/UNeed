using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNeedTickets.Migrations
{
    /// <inheritdoc />
    public partial class addrequesttypefieldintickettable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RequestType",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestType",
                table: "Tickets");
        }
    }
}
