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
    [Migration("20240126191125_mig8")]
    partial class mig8
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

                    b.Property<int>("RequestApprovalStatusId")
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
                            RequestDate = new DateTime(2024, 1, 26, 22, 11, 24, 817, DateTimeKind.Local).AddTicks(5145),
                            StartingDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VocationLeaveTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 2,
                            EndingDate = new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RequestApprovalStatusId = 2,
                            RequestDate = new DateTime(2024, 1, 26, 22, 11, 24, 817, DateTimeKind.Local).AddTicks(5153),
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

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DateOfDismissal")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DateOfEmployment")
                        .HasColumnType("datetimeoffset");

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
                            DateOfBirth = new DateTimeOffset(new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            DateOfEmployment = new DateTimeOffset(new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            Department = "IT",
                            Email = "hakan.toraman@bilgeadamboost.com",
                            EmailForRegister = "hakantoraman@gmail.com",
                            FirstName = "Hakan",
                            LastName = "Toraman",
                            PasswordHash = new byte[] { 228, 34, 228, 151, 241, 113, 74, 98, 90, 255, 171, 111, 116, 180, 40, 62, 202, 77, 159, 157, 237, 92, 126, 124, 66, 47, 185, 128, 204, 122, 27, 30, 204, 221, 73, 252, 9, 36, 119, 104, 34, 1, 233, 214, 150, 49, 204, 241, 175, 159, 83, 252, 186, 211, 122, 234, 45, 19, 173, 80, 209, 222, 33, 104 },
                            PasswordSalt = new byte[] { 40, 86, 215, 69, 78, 175, 21, 136, 100, 38, 223, 189, 107, 172, 12, 208, 228, 125, 105, 112, 39, 48, 186, 82, 184, 79, 21, 167, 120, 171, 13, 127, 119, 19, 59, 134, 81, 64, 99, 141, 41, 87, 87, 31, 207, 43, 180, 199, 205, 239, 250, 111, 110, 230, 106, 91, 30, 207, 221, 123, 151, 130, 239, 179, 67, 125, 220, 38, 23, 139, 214, 202, 137, 209, 76, 186, 96, 152, 121, 167, 46, 34, 41, 180, 227, 170, 241, 139, 233, 38, 107, 7, 156, 216, 83, 35, 47, 2, 22, 86, 215, 72, 72, 249, 29, 235, 248, 249, 135, 97, 47, 129, 165, 255, 40, 82, 91, 51, 179, 33, 39, 13, 235, 174, 208, 86, 135, 83 },
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
                            DateOfBirth = new DateTimeOffset(new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            DateOfEmployment = new DateTimeOffset(new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            Department = "IT",
                            Email = "furkan.altinbarin@bilgeadamboost.com",
                            EmailForRegister = "furkanaltinbarin@gmail.com",
                            FirstName = "Furkan",
                            LastName = "Altınbarın",
                            PasswordHash = new byte[] { 193, 105, 156, 9, 31, 194, 11, 28, 0, 36, 106, 161, 117, 63, 170, 44, 151, 18, 248, 75, 247, 151, 82, 9, 54, 168, 48, 242, 131, 92, 223, 149, 69, 207, 142, 191, 106, 39, 78, 80, 133, 47, 20, 137, 104, 216, 215, 175, 89, 35, 111, 89, 87, 76, 197, 73, 79, 110, 225, 193, 63, 151, 213, 64 },
                            PasswordSalt = new byte[] { 226, 210, 103, 102, 186, 123, 180, 2, 193, 128, 118, 161, 195, 19, 129, 101, 151, 254, 153, 144, 226, 76, 45, 89, 36, 30, 101, 78, 40, 14, 145, 84, 235, 15, 75, 19, 84, 230, 122, 95, 246, 218, 184, 34, 63, 77, 206, 115, 57, 235, 240, 239, 182, 254, 45, 76, 89, 102, 215, 238, 139, 14, 117, 21, 154, 94, 111, 89, 79, 187, 183, 7, 29, 147, 225, 255, 222, 188, 242, 117, 189, 69, 230, 152, 30, 189, 158, 193, 4, 10, 51, 38, 238, 232, 40, 253, 15, 114, 16, 16, 38, 118, 231, 37, 85, 52, 55, 142, 158, 81, 86, 109, 109, 59, 185, 209, 8, 255, 117, 13, 192, 80, 206, 232, 7, 193, 160, 35 },
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