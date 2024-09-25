using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Veterinary.API.Migrations
{
    /// <inheritdoc />
    public partial class FixedPhoneString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FixedPhone",
                table: "Owners",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 7);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FixedPhone",
                table: "Owners",
                type: "int",
                maxLength: 7,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);
        }
    }
}
