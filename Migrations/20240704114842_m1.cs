using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTask.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EmployeeManagers_EmployeeManagerId",
                table: "EmployeeManagers",
                column: "EmployeeManagerId",
                unique: false,
                filter: "[EmployeeManagerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeManagers_EmployeeManagers_EmployeeManagerId",
                table: "EmployeeManagers",
                column: "EmployeeManagerId",
                principalTable: "EmployeeManagers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeManagers_EmployeeManagers_EmployeeManagerId",
                table: "EmployeeManagers");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeManagers_EmployeeManagerId",
                table: "EmployeeManagers");
        }
    }
}
