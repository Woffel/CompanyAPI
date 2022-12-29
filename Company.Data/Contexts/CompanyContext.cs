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

        public DbSet<Companies> companies => Set<Companies>();

        public DbSet<Departments> departments => Set<Departments>();

        public DbSet<Employees> employees => Set<Employees>();
        public DbSet<Positions> positions => Set<Positions>();
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           // builder.Entity<CompanyDepartments>().HasKey(ci => new { ci.CompanyId, ci.DepartmentId });
           // builder.Entity<EmployeePositions>().HasKey(ci => new { ci.employeeId, ci.positionId });

        }
    }
}
