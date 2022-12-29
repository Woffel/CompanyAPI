using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class keys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDepartments_companies_CompanyId1",
                table: "CompanyDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_companies_CompanyId",
                table: "employees");

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
                name: "CompanyId",
                table: "employees",
                newName: "CompanyIdId");

            migrationBuilder.RenameIndex(
                name: "IX_employees_CompanyId",
                table: "employees",
                newName: "IX_employees_CompanyIdId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments",
                columns: new[] { "CompayId", "DepartmentId" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartments_CompanyId",
                table: "CompanyDepartments",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDepartments_companies_CompanyId",
                table: "CompanyDepartments",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_companies_CompanyIdId",
                table: "employees",
                column: "CompanyIdId",
                principalTable: "companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDepartments_companies_CompanyId",
                table: "CompanyDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_companies_CompanyIdId",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments");

            migrationBuilder.DropIndex(
                name: "IX_CompanyDepartments_CompanyId",
                table: "CompanyDepartments");

            migrationBuilder.DropColumn(
                name: "CompayId",
                table: "CompanyDepartments");

            migrationBuilder.RenameColumn(
                name: "CompanyIdId",
                table: "employees",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_employees_CompanyIdId",
                table: "employees",
                newName: "IX_employees_CompanyId");

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
                name: "FK_employees_companies_CompanyId",
                table: "employees",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
