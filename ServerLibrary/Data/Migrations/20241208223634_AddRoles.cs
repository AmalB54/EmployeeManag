using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerLibrary.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "ApplicationUsers",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ApplicationUsers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "ApplicationUsers",
                newName: "Fullname");

            migrationBuilder.CreateTable(
                name: "SystemRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemRoles");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "ApplicationUsers",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ApplicationUsers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "ApplicationUsers",
                newName: "name");
        }
    }
}
