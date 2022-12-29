using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDepartments_companies_companyId",
                table: "CompanyDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDepartments_departments_departmentsId",
                table: "CompanyDepartments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments");

            migrationBuilder.DropIndex(
                name: "IX_CompanyDepartments_companyId",
                table: "CompanyDepartments");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "CompanyDepartments");

            migrationBuilder.RenameColumn(
                name: "departmentsId",
                table: "CompanyDepartments",
                newName: "DepartmentsId");

            migrationBuilder.RenameColumn(
                name: "companyId",
                table: "CompanyDepartments",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyDepartments_departmentsId",
                table: "CompanyDepartments",
                newName: "IX_CompanyDepartments_DepartmentsId");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "CompanyDepartments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyId1",
                table: "CompanyDepartments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments",
                columns: new[] { "CompanyId", "DepartmentId" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartments_CompanyId1",
                table: "CompanyDepartments",
                column: "CompanyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDepartments_companies_CompanyId1",
                table: "CompanyDepartments",
                column: "CompanyId1",
                principalTable: "companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDepartments_departments_DepartmentsId",
                table: "CompanyDepartments",
                column: "DepartmentsId",
                principalTable: "departments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDepartments_companies_CompanyId1",
                table: "CompanyDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDepartments_departments_DepartmentsId",
                table: "CompanyDepartments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments");

            migrationBuilder.DropIndex(
                name: "IX_CompanyDepartments_CompanyId1",
                table: "CompanyDepartments");

            migrationBuilder.DropColumn(
                name: "CompanyId1",
                table: "CompanyDepartments");

            migrationBuilder.RenameColumn(
                name: "DepartmentsId",
                table: "CompanyDepartments",
                newName: "departmentsId");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "CompanyDepartments",
                newName: "companyId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyDepartments_DepartmentsId",
                table: "CompanyDepartments",
                newName: "IX_CompanyDepartments_departmentsId");

            migrationBuilder.AlterColumn<string>(
                name: "companyId",
                table: "CompanyDepartments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "CompanyDepartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments",
                columns: new[] { "CompanyId", "DepartmentId" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartments_companyId",
                table: "CompanyDepartments",
                column: "companyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDepartments_companies_companyId",
                table: "CompanyDepartments",
                column: "companyId",
                principalTable: "companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDepartments_departments_departmentsId",
                table: "CompanyDepartments",
                column: "departmentsId",
                principalTable: "departments",
                principalColumn: "Id");
        }
    }
}
