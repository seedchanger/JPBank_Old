using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JPBank.Migrations
{
    /// <inheritdoc />
    public partial class RenamedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersDbSet",
                table: "UsersDbSet");

            migrationBuilder.RenameTable(
                name: "UsersDbSet",
                newName: "Tbl_Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Users",
                table: "Tbl_Users",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Users",
                table: "Tbl_Users");

            migrationBuilder.RenameTable(
                name: "Tbl_Users",
                newName: "UsersDbSet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersDbSet",
                table: "UsersDbSet",
                column: "UserId");
        }
    }
}
