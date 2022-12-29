using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class comps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "CompanyDepartments",
                newName: "companyId");

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

            migrationBuilder.AddColumn<int>(
                name: "departmentsId",
                table: "CompanyDepartments",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments",
                columns: new[] { "CompanyId", "DepartmentId" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartments_companyId",
                table: "CompanyDepartments",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartments_departmentsId",
                table: "CompanyDepartments",
                column: "departmentsId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_CompanyDepartments_departmentsId",
                table: "CompanyDepartments");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "CompanyDepartments");

            migrationBuilder.DropColumn(
                name: "departmentsId",
                table: "CompanyDepartments");

            migrationBuilder.RenameColumn(
                name: "companyId",
                table: "CompanyDepartments",
                newName: "CompanyId");

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
        }
    }
}
