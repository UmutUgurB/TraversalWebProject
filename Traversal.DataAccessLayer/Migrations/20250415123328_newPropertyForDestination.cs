using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traversal.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class newPropertyForDestination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Destinations");
        }
    }
}
