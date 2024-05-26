using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityTourist.Migrations
{
    /// <inheritdoc />
    public partial class AddRouteForPlace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Routes",
                table: "Place",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Routes",
                table: "Place");
        }
    }
}
