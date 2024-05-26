using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityTourist.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedPlacesAndCityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Place",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "City",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Place");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "City");
        }
    }
}
