using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocoParser.Core.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemUrl",
                table: "Prices",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemUrl",
                table: "Prices");
        }
    }
}
