using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class CompanyDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDepartment_Companies_CompanyId",
                table: "CompanyDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDepartment_Departments_DepartmentId",
                table: "CompanyDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_CompanyDepartment_CompanyDepartmentCompanyId_CompanyDepartmentDepartmentId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyDepartment",
                table: "CompanyDepartment");

            migrationBuilder.RenameTable(
                name: "CompanyDepartment",
                newName: "CompanyDepartments");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyDepartment_DepartmentId",
                table: "CompanyDepartments",
                newName: "IX_CompanyDepartments_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments",
                columns: new[] { "CompanyId", "DepartmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDepartments_Companies_CompanyId",
                table: "CompanyDepartments",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDepartments_Departments_DepartmentId",
                table: "CompanyDepartments",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_CompanyDepartments_CompanyDepartmentCompanyId_CompanyDepartmentDepartmentId",
                table: "Employees",
                columns: new[] { "CompanyDepartmentCompanyId", "CompanyDepartmentDepartmentId" },
                principalTable: "CompanyDepartments",
                principalColumns: new[] { "CompanyId", "DepartmentId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDepartments_Companies_CompanyId",
                table: "CompanyDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDepartments_Departments_DepartmentId",
                table: "CompanyDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_CompanyDepartments_CompanyDepartmentCompanyId_CompanyDepartmentDepartmentId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments");

            migrationBuilder.RenameTable(
                name: "CompanyDepartments",
                newName: "CompanyDepartment");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyDepartments_DepartmentId",
                table: "CompanyDepartment",
                newName: "IX_CompanyDepartment_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyDepartment",
                table: "CompanyDepartment",
                columns: new[] { "CompanyId", "DepartmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDepartment_Companies_CompanyId",
                table: "CompanyDepartment",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDepartment_Departments_DepartmentId",
                table: "CompanyDepartment",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_CompanyDepartment_CompanyDepartmentCompanyId_CompanyDepartmentDepartmentId",
                table: "Employees",
                columns: new[] { "CompanyDepartmentCompanyId", "CompanyDepartmentDepartmentId" },
                principalTable: "CompanyDepartment",
                principalColumns: new[] { "CompanyId", "DepartmentId" });
        }
    }
}
