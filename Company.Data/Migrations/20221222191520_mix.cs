using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class mix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDepartments_companies_CompanyId",
                table: "CompanyDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDepartments_departments_DepartmentsId",
                table: "CompanyDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_companies_CompanyIdId",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_DepartmentId",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_positions_PositionsId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_CompanyIdId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_DepartmentId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_PositionsId",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments");

            migrationBuilder.DropIndex(
                name: "IX_CompanyDepartments_CompanyId",
                table: "CompanyDepartments");

            migrationBuilder.DropIndex(
                name: "IX_CompanyDepartments_DepartmentsId",
                table: "CompanyDepartments");

            migrationBuilder.DropColumn(
                name: "CompanyIdId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "PositionsId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "CompayId",
                table: "CompanyDepartments");

            migrationBuilder.DropColumn(
                name: "DepartmentsId",
                table: "CompanyDepartments");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "employees",
                newName: "DepartmentIdCompanyId");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId1",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyIdDepartmentId",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId1",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "CompanyDepartments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments",
                columns: new[] { "CompanyId", "DepartmentId" });

            migrationBuilder.CreateIndex(
                name: "IX_employees_CompanyId1_CompanyIdDepartmentId",
                table: "employees",
                columns: new[] { "CompanyId1", "CompanyIdDepartmentId" });

            migrationBuilder.CreateIndex(
                name: "IX_employees_DepartmentIdCompanyId_DepartmentId1",
                table: "employees",
                columns: new[] { "DepartmentIdCompanyId", "DepartmentId1" });

            migrationBuilder.AddForeignKey(
                name: "FK_employees_CompanyDepartments_CompanyId1_CompanyIdDepartmentId",
                table: "employees",
                columns: new[] { "CompanyId1", "CompanyIdDepartmentId" },
                principalTable: "CompanyDepartments",
                principalColumns: new[] { "CompanyId", "DepartmentId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_CompanyDepartments_DepartmentIdCompanyId_DepartmentId1",
                table: "employees",
                columns: new[] { "DepartmentIdCompanyId", "DepartmentId1" },
                principalTable: "CompanyDepartments",
                principalColumns: new[] { "CompanyId", "DepartmentId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_CompanyDepartments_CompanyId1_CompanyIdDepartmentId",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_CompanyDepartments_DepartmentIdCompanyId_DepartmentId1",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_CompanyId1_CompanyIdDepartmentId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_DepartmentIdCompanyId_DepartmentId1",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments");

            migrationBuilder.DropColumn(
                name: "CompanyId1",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "CompanyIdDepartmentId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "employees");

            migrationBuilder.RenameColumn(
                name: "DepartmentIdCompanyId",
                table: "employees",
                newName: "DepartmentId");

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdId",
                table: "employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PositionsId",
                table: "employees",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyId",
                table: "CompanyDepartments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CompayId",
                table: "CompanyDepartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentsId",
                table: "CompanyDepartments",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments",
                columns: new[] { "CompayId", "DepartmentId" });

            migrationBuilder.CreateIndex(
                name: "IX_employees_CompanyIdId",
                table: "employees",
                column: "CompanyIdId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_DepartmentId",
                table: "employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_PositionsId",
                table: "employees",
                column: "PositionsId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartments_CompanyId",
                table: "CompanyDepartments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartments_DepartmentsId",
                table: "CompanyDepartments",
                column: "DepartmentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDepartments_companies_CompanyId",
                table: "CompanyDepartments",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDepartments_departments_DepartmentsId",
                table: "CompanyDepartments",
                column: "DepartmentsId",
                principalTable: "departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_companies_CompanyIdId",
                table: "employees",
                column: "CompanyIdId",
                principalTable: "companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_DepartmentId",
                table: "employees",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_positions_PositionsId",
                table: "employees",
                column: "PositionsId",
                principalTable: "positions",
                principalColumn: "Id");
        }
    }
}
