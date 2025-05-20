using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dsd603Vm2025JBC.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedBusiness : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Business",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Business",
                table: "Visitors");
        }
    }
}
