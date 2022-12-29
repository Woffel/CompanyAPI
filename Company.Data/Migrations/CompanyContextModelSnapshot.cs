﻿// <auto-generated />
using System;
using Company.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Company.Data.Migrations
{
    [DbContext(typeof(CompanyContext))]
    partial class CompanyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Company.Data.Entities.Companies", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("Company.Data.Entities.CompanyDepartments", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("CompanyId", "DepartmentId");

                    b.ToTable("CompanyDepartments");
                });

            modelBuilder.Entity("Company.Data.Entities.Departments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("Company.Data.Entities.EmployeePositions", b =>
                {
                    b.Property<int?>("employeeId")
                        .HasColumnType("int");

                    b.Property<int?>("positionId")
                        .HasColumnType("int");

                    b.HasKey("employeeId", "positionId");

                    b.ToTable("EmployeePositions");
                });

            modelBuilder.Entity("Company.Data.Entities.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyId1")
                        .HasColumnType("int");

                    b.Property<int>("CompanyIdDepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId1")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentIdCompanyId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<bool>("UnionMember")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId1", "CompanyIdDepartmentId");

                    b.HasIndex("DepartmentIdCompanyId", "DepartmentId1");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("Company.Data.Entities.Positions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("positions");
                });

            modelBuilder.Entity("Company.Data.Entities.Employees", b =>
                {
                    b.HasOne("Company.Data.Entities.CompanyDepartments", "CompanyId")
                        .WithMany()
                        .HasForeignKey("CompanyId1", "CompanyIdDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Company.Data.Entities.CompanyDepartments", "DepartmentId")
                        .WithMany()
                        .HasForeignKey("DepartmentIdCompanyId", "DepartmentId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyId");

                    b.Navigation("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
