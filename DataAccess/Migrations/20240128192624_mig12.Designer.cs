﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(HrDbContext))]
    [Migration("20240128192624_mig12")]
    partial class mig12
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "user"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.RequestApprovalStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RequestApprovalStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pending"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Approved"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rejected"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Canceled"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.SpendingRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<byte?>("Folder")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RequestApprovalStatusId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ResponseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SpendingRequests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Currency = "₺",
                            EmployeeId = 2,
                            Name = "Yakıt Gideri",
                            Price = 500m,
                            RequestApprovalStatusId = 1,
                            RequestDate = new DateTime(2024, 1, 28, 22, 26, 23, 773, DateTimeKind.Local).AddTicks(8557)
                        },
                        new
                        {
                            Id = 2,
                            Currency = "₺",
                            EmployeeId = 1,
                            Name = "Yemek Gideri",
                            Price = 200m,
                            RequestApprovalStatusId = 2,
                            RequestDate = new DateTime(2024, 1, 28, 22, 26, 23, 773, DateTimeKind.Local).AddTicks(8571)
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserOperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 1,
                            OperationClaimId = 1
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 2,
                            OperationClaimId = 2
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.VocationLeaveRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndingDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RequestApprovalStatusId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ResponseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VocationLeaveTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VocationLeaveRequests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 2,
                            EndingDate = new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RequestApprovalStatusId = 1,
                            RequestDate = new DateTime(2024, 1, 28, 22, 26, 23, 774, DateTimeKind.Local).AddTicks(6597),
                            StartingDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VocationLeaveTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 2,
                            EndingDate = new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RequestApprovalStatusId = 2,
                            RequestDate = new DateTime(2024, 1, 28, 22, 26, 23, 774, DateTimeKind.Local).AddTicks(6604),
                            StartingDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VocationLeaveTypeId = 2
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.VocationLeaveType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VocationLeaveTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Day = 14,
                            Name = "Annual Leave"
                        },
                        new
                        {
                            Id = 2,
                            Day = 5,
                            Name = "Sick Leave"
                        },
                        new
                        {
                            Id = 3,
                            Day = 3,
                            Name = "Marriage Leave"
                        },
                        new
                        {
                            Id = 4,
                            Day = 120,
                            Name = "Maternity Leave"
                        },
                        new
                        {
                            Id = 5,
                            Day = 5,
                            Name = "Paternity Leave"
                        },
                        new
                        {
                            Id = 6,
                            Day = 3,
                            Name = "Bereavement Leave"
                        },
                        new
                        {
                            Id = 7,
                            Day = 1,
                            Name = "Unpaid Leave"
                        },
                        new
                        {
                            Id = 8,
                            Day = 1,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("BirthLocation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfDismissal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfEmployment")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailForRegister")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(500)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(500)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SecondLastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.Property<string>("TurkishIdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Address = "Kartal",
                            BirthLocation = "İstanbul",
                            City = "İstanbul",
                            Company = "Bilge Adam",
                            DateOfBirth = new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfEmployment = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "IT",
                            Email = "hakan.toraman@bilgeadamboost.com",
                            EmailForRegister = "hakantoraman@gmail.com",
                            FirstName = "Hakan",
                            LastName = "Toraman",
                            PasswordHash = new byte[] { 79, 153, 28, 86, 161, 214, 26, 197, 194, 177, 231, 164, 56, 44, 239, 121, 254, 212, 194, 135, 6, 200, 102, 199, 113, 0, 206, 14, 128, 106, 117, 28, 58, 213, 143, 194, 240, 134, 76, 253, 158, 210, 225, 40, 146, 104, 186, 89, 108, 90, 58, 12, 138, 124, 236, 22, 29, 148, 83, 170, 96, 76, 154, 140 },
                            PasswordSalt = new byte[] { 70, 185, 231, 206, 13, 53, 30, 127, 235, 69, 23, 43, 78, 83, 43, 247, 181, 49, 254, 211, 248, 187, 107, 205, 141, 106, 31, 170, 28, 202, 36, 99, 118, 92, 215, 104, 167, 125, 133, 196, 201, 192, 206, 160, 109, 128, 187, 217, 213, 218, 228, 107, 236, 76, 30, 50, 38, 79, 35, 155, 38, 24, 141, 200, 116, 213, 136, 79, 4, 7, 62, 167, 34, 24, 113, 111, 145, 119, 59, 233, 128, 253, 117, 212, 244, 50, 113, 156, 114, 96, 5, 193, 19, 25, 203, 40, 190, 111, 79, 41, 12, 3, 147, 67, 204, 222, 233, 237, 210, 136, 243, 143, 82, 223, 90, 36, 140, 25, 186, 166, 137, 132, 250, 172, 130, 241, 253, 247 },
                            PhoneNumber = "05321234567",
                            Position = "Junior Developer",
                            Profession = "Software Developer",
                            Salary = 10000m,
                            Status = true,
                            TitleId = 2,
                            TurkishIdentificationNumber = "12345678910"
                        },
                        new
                        {
                            Id = 1,
                            Address = "Kadıköy",
                            BirthLocation = "İstanbul",
                            City = "İstanbul",
                            Company = "Bilge Adam",
                            DateOfBirth = new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfEmployment = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "IT",
                            Email = "furkan.altinbarin@bilgeadamboost.com",
                            EmailForRegister = "furkanaltinbarin@gmail.com",
                            FirstName = "Furkan",
                            LastName = "Altınbarın",
                            PasswordHash = new byte[] { 131, 103, 124, 168, 238, 244, 10, 203, 237, 156, 84, 65, 162, 6, 121, 206, 137, 87, 243, 38, 165, 95, 133, 129, 81, 39, 91, 2, 60, 143, 92, 148, 177, 138, 86, 145, 153, 137, 239, 113, 64, 61, 45, 43, 10, 229, 226, 129, 234, 224, 135, 1, 223, 114, 95, 146, 21, 119, 223, 213, 2, 62, 240, 253 },
                            PasswordSalt = new byte[] { 236, 51, 198, 224, 182, 220, 84, 71, 237, 193, 142, 132, 50, 90, 38, 208, 136, 44, 241, 14, 144, 11, 47, 40, 125, 254, 163, 221, 214, 203, 155, 98, 194, 5, 35, 6, 60, 109, 71, 149, 95, 80, 102, 249, 72, 56, 67, 213, 240, 168, 73, 68, 24, 119, 195, 208, 50, 88, 108, 198, 199, 79, 119, 95, 248, 60, 85, 29, 163, 227, 2, 141, 212, 68, 224, 74, 127, 124, 242, 244, 243, 12, 177, 75, 120, 8, 48, 104, 168, 213, 47, 190, 24, 91, 253, 8, 18, 27, 63, 160, 187, 251, 121, 147, 201, 68, 26, 66, 246, 177, 34, 144, 24, 232, 200, 59, 111, 42, 190, 107, 4, 42, 88, 62, 9, 69, 28, 230 },
                            PhoneNumber = "05321234567",
                            Position = "Head of Department",
                            Profession = "Software Developer",
                            Salary = 10000m,
                            Status = true,
                            TitleId = 1,
                            TurkishIdentificationNumber = "12345678910"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Title");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Manager"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Software Developer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
