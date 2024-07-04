using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTask.Migrations
{
    /// <inheritdoc />
    public partial class selfJoinTableFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeManagers_EmployeeManagers_EmployeeManagerId",
                table: "EmployeeManagers");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeManagers_EmployeeManagerId",
                table: "EmployeeManagers");

            migrationBuilder.RenameColumn(
                name: "EmployeeManagerId",
                table: "EmployeeManagers",
                newName: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeManagers_ManagerId",
                table: "EmployeeManagers",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeManagers_EmployeeManagers_ManagerId",
                table: "EmployeeManagers",
                column: "ManagerId",
                principalTable: "EmployeeManagers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeManagers_EmployeeManagers_ManagerId",
                table: "EmployeeManagers");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeManagers_ManagerId",
                table: "EmployeeManagers");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "EmployeeManagers",
                newName: "EmployeeManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeManagers_EmployeeManagerId",
                table: "EmployeeManagers",
                column: "EmployeeManagerId",
                unique: true,
                filter: "[EmployeeManagerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeManagers_EmployeeManagers_EmployeeManagerId",
                table: "EmployeeManagers",
                column: "EmployeeManagerId",
                principalTable: "EmployeeManagers",
                principalColumn: "Id");
        }
    }
}
