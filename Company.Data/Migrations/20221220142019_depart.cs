using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class depart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_DepartmentsId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_DepartmentsId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "PositionName",
                table: "positions");

            migrationBuilder.DropColumn(
                name: "DepartmentsId",
                table: "employees");

            migrationBuilder.AddColumn<int>(
                name: "PositionsId",
                table: "employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeesId",
                table: "departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_PositionsId",
                table: "employees",
                column: "PositionsId");

            migrationBuilder.CreateIndex(
                name: "IX_departments_EmployeesId",
                table: "departments",
                column: "EmployeesId");

            migrationBuilder.AddForeignKey(
                name: "FK_departments_employees_EmployeesId",
                table: "departments",
                column: "EmployeesId",
                principalTable: "employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_positions_PositionsId",
                table: "employees",
                column: "PositionsId",
                principalTable: "positions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_employees_EmployeesId",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_positions_PositionsId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_PositionsId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_departments_EmployeesId",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "PositionsId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "EmployeesId",
                table: "departments");

            migrationBuilder.AddColumn<string>(
                name: "PositionName",
                table: "positions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentsId",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_employees_DepartmentsId",
                table: "employees",
                column: "DepartmentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_DepartmentsId",
                table: "employees",
                column: "DepartmentsId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
