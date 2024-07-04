﻿// <auto-generated />
using System;
using EFCoreTask.Core.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreTask.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240704114842_m1")]
    partial class m1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreTask.Core.Domain.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Royal Villa",
                            Price = 200.0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Decent Villa",
                            Price = 400.0
                        });
                });

            modelBuilder.Entity("EFCoreTask.Core.Domain.Models.VillaAmanity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VillaId");

                    b.ToTable("VillaAmanities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pool",
                            VillaId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Microwave oven",
                            VillaId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bed",
                            VillaId = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Library room",
                            VillaId = 1
                        });
                });

            modelBuilder.Entity("EFCoreTask.Core.Domain.TaskModel.EmployeeManager", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeManagerId")
                        .IsUnique()
                        .HasFilter("[EmployeeManagerId] IS NOT NULL");

                    b.ToTable("EmployeeManagers");
                });

            modelBuilder.Entity("EFCoreTask.Core.Domain.TaskModel.Student", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RollNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("EFCoreTask.Core.Domain.TaskModel.StudentAdmissionForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppliedFieldName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentAdmissionForm");
                });

            modelBuilder.Entity("EFCoreTask.Core.Domain.TaskModel.StudentInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FSCMarksPercentage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentInfo");
                });

            modelBuilder.Entity("EFCoreTask.Core.Domain.TaskModel.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("TeacherDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("EFCoreTask.Core.Domain.View.AllEmployeeManager", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<Guid>("ManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable((string)null);

                    b.ToView("AllEmployeeManager", (string)null);
                });

            modelBuilder.Entity("StudentTeacher", b =>
                {
                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.Property<int>("TeachersTeacherId")
                        .HasColumnType("int");

                    b.HasKey("StudentsId", "TeachersTeacherId");

                    b.HasIndex("TeachersTeacherId");

                    b.ToTable("StudentTeacher");
                });

            modelBuilder.Entity("EFCoreTask.Core.Domain.Models.VillaAmanity", b =>
                {
                    b.HasOne("EFCoreTask.Core.Domain.Models.Villa", "Villa")
                        .WithMany("villaAmanities")
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });

            modelBuilder.Entity("EFCoreTask.Core.Domain.TaskModel.EmployeeManager", b =>
                {
                    b.HasOne("EFCoreTask.Core.Domain.TaskModel.EmployeeManager", "employeeManager")
                        .WithOne()
                        .HasForeignKey("EFCoreTask.Core.Domain.TaskModel.EmployeeManager", "EmployeeManagerId");

                    b.Navigation("employeeManager");
                });

            modelBuilder.Entity("EFCoreTask.Core.Domain.TaskModel.StudentAdmissionForm", b =>
                {
                    b.HasOne("EFCoreTask.Core.Domain.TaskModel.Student", "Student")
                        .WithMany("admissionForms")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EFCoreTask.Core.Domain.TaskModel.StudentInfo", b =>
                {
                    b.HasOne("EFCoreTask.Core.Domain.TaskModel.Student", "Student")
                        .WithOne()
                        .HasForeignKey("EFCoreTask.Core.Domain.TaskModel.StudentInfo", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EFCoreTask.Core.Domain.View.AllEmployeeManager", b =>
                {
                    b.HasOne("EFCoreTask.Core.Domain.TaskModel.EmployeeManager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("StudentTeacher", b =>
                {
                    b.HasOne("EFCoreTask.Core.Domain.TaskModel.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreTask.Core.Domain.TaskModel.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeachersTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreTask.Core.Domain.Models.Villa", b =>
                {
                    b.Navigation("villaAmanities");
                });

            modelBuilder.Entity("EFCoreTask.Core.Domain.TaskModel.Student", b =>
                {
                    b.Navigation("admissionForms");
                });
#pragma warning restore 612, 618
        }
    }
}
