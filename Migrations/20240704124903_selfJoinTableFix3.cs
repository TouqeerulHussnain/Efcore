using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTask.Migrations
{
    /// <inheritdoc />
    public partial class selfJoinTableFix3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeManagers_EmployeeManagers_ManagerId",
                table: "EmployeeManagers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeManagers",
                table: "EmployeeManagers");

            migrationBuilder.RenameTable(
                name: "EmployeeManagers",
                newName: "Employee");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeManagers_ManagerId",
                table: "Employee",
                newName: "IX_Employee_ManagerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Employee_ManagerId",
                table: "Employee",
                column: "ManagerId",
                principalTable: "Employee",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Employee_ManagerId",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "EmployeeManagers");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_ManagerId",
                table: "EmployeeManagers",
                newName: "IX_EmployeeManagers_ManagerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeManagers",
                table: "EmployeeManagers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeManagers_EmployeeManagers_ManagerId",
                table: "EmployeeManagers",
                column: "ManagerId",
                principalTable: "EmployeeManagers",
                principalColumn: "Id");
        }
    }
}
