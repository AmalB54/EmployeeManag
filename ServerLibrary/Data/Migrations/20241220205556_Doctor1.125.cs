using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerLibrary.Data.Migrations
{
    /// <inheritdoc />
    public partial class Doctor1125 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_VacationsTypes_VacationTypeId",
                table: "Vacations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacationsTypes",
                table: "VacationsTypes");

            migrationBuilder.DropColumn(
                name: "CivilId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "FileNumber",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Other",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "CivilId",
                table: "Sanctions");

            migrationBuilder.DropColumn(
                name: "FileNumber",
                table: "Sanctions");

            migrationBuilder.DropColumn(
                name: "Other",
                table: "Sanctions");

            migrationBuilder.DropColumn(
                name: "CivilId",
                table: "Overtimes");

            migrationBuilder.DropColumn(
                name: "FileNumber",
                table: "Overtimes");

            migrationBuilder.DropColumn(
                name: "Other",
                table: "Overtimes");

            migrationBuilder.DropColumn(
                name: "CivilId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "FileNumber",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Other",
                table: "Doctors");

            migrationBuilder.RenameTable(
                name: "VacationsTypes",
                newName: "VacationTypes");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Sanctions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Overtimes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacationTypes",
                table: "VacationTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_VacationTypes_VacationTypeId",
                table: "Vacations",
                column: "VacationTypeId",
                principalTable: "VacationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_VacationTypes_VacationTypeId",
                table: "Vacations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VacationTypes",
                table: "VacationTypes");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Sanctions");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Overtimes");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Doctors");

            migrationBuilder.RenameTable(
                name: "VacationTypes",
                newName: "VacationsTypes");

            migrationBuilder.AddColumn<string>(
                name: "CivilId",
                table: "Vacations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileNumber",
                table: "Vacations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Other",
                table: "Vacations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CivilId",
                table: "Sanctions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileNumber",
                table: "Sanctions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Other",
                table: "Sanctions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CivilId",
                table: "Overtimes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileNumber",
                table: "Overtimes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Other",
                table: "Overtimes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CivilId",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileNumber",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Other",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VacationsTypes",
                table: "VacationsTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_VacationsTypes_VacationTypeId",
                table: "Vacations",
                column: "VacationTypeId",
                principalTable: "VacationsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
