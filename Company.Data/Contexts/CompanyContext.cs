using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Company.Data.Contexts
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        public DbSet<Company.Data.Entities.Company> Companies => Set<Company.Data.Entities.Company>();

        public DbSet<Department> Departments => Set<Department>();

        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Position> Positions => Set<Position>();
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CompanyDepartment>().HasKey(ci => new { ci.CompanyId, ci.DepartmentId });
            builder.Entity<CompanyDepartment>()
            .HasOne(bc => bc.Company)
            .WithMany(b => b.Departments)
            .HasForeignKey(bc => bc.CompanyId);

            builder.Entity<CompanyDepartment>()
            .HasOne(bc => bc.Department)
            .WithMany(c => c.Companies)
            .HasForeignKey(bc => bc.DepartmentId);

            builder.Entity<Employee>()
            .HasOne(bc => bc.CompanyDepartment)
            .WithMany(c => c.Employees);

            
            builder.Entity<EmployeePositions>().HasKey(ci => new { ci.EmployeeId, ci.PositionId });
            builder.Entity<EmployeePositions>()
            .HasOne(bc => bc.Employee)
            .WithMany(b => b.Positions)
            .HasForeignKey(bc => bc.EmployeeId);

            builder.Entity<EmployeePositions>()
            .HasOne(bc => bc.Position)
            .WithMany(c => c.Employees)
            .HasForeignKey(bc => bc.PositionId);

            

        }
    }
}
