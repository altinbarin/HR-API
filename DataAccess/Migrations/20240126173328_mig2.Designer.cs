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
    [Migration("20240126173328_mig2")]
    partial class mig2
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
                            RequestDate = new DateTime(2024, 1, 26, 20, 33, 28, 258, DateTimeKind.Local).AddTicks(7604),
                            StartingDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VocationLeaveTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 2,
                            EndingDate = new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RequestApprovalStatusId = 2,
                            RequestDate = new DateTime(2024, 1, 26, 20, 33, 28, 258, DateTimeKind.Local).AddTicks(7616),
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
                            PasswordHash = new byte[] { 127, 165, 119, 219, 56, 252, 159, 99, 93, 150, 48, 101, 237, 89, 243, 41, 44, 11, 99, 134, 81, 67, 71, 138, 56, 19, 19, 209, 152, 154, 72, 238, 250, 147, 25, 135, 29, 148, 183, 152, 14, 0, 111, 236, 255, 145, 76, 32, 158, 52, 17, 133, 114, 137, 254, 176, 241, 169, 64, 187, 14, 61, 186, 154 },
                            PasswordSalt = new byte[] { 62, 76, 41, 14, 149, 79, 138, 27, 5, 253, 158, 77, 34, 162, 63, 252, 78, 5, 105, 90, 206, 187, 122, 145, 189, 172, 23, 22, 120, 128, 57, 55, 164, 252, 129, 107, 10, 129, 115, 175, 223, 69, 223, 183, 90, 137, 165, 68, 219, 27, 254, 46, 14, 110, 147, 159, 92, 12, 216, 223, 38, 45, 207, 161, 123, 248, 170, 127, 40, 255, 128, 5, 237, 219, 209, 30, 229, 17, 142, 253, 108, 33, 151, 127, 64, 229, 112, 225, 253, 121, 120, 171, 179, 93, 52, 9, 38, 138, 197, 121, 36, 36, 121, 69, 57, 101, 38, 147, 179, 20, 61, 217, 177, 8, 252, 78, 157, 77, 140, 103, 4, 13, 79, 20, 233, 27, 213, 65 },
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
                            PasswordHash = new byte[] { 53, 131, 194, 3, 8, 79, 18, 122, 158, 91, 187, 244, 30, 142, 7, 135, 255, 98, 193, 189, 116, 57, 62, 219, 74, 72, 219, 59, 40, 181, 213, 118, 219, 114, 151, 111, 231, 195, 59, 212, 76, 78, 218, 177, 248, 161, 65, 36, 189, 117, 12, 28, 236, 51, 68, 41, 101, 125, 19, 240, 241, 134, 250, 38 },
                            PasswordSalt = new byte[] { 196, 97, 34, 77, 117, 89, 127, 29, 168, 47, 177, 206, 49, 157, 121, 133, 187, 149, 178, 65, 190, 254, 183, 34, 9, 151, 124, 108, 62, 168, 253, 130, 219, 44, 149, 12, 136, 161, 165, 250, 3, 31, 114, 117, 52, 17, 110, 174, 247, 36, 244, 173, 217, 158, 243, 149, 249, 67, 255, 144, 194, 89, 99, 208, 106, 59, 221, 255, 216, 176, 249, 92, 231, 45, 249, 146, 133, 13, 151, 178, 19, 72, 16, 141, 129, 221, 175, 160, 175, 10, 102, 71, 234, 79, 20, 129, 4, 66, 211, 88, 178, 241, 228, 246, 76, 81, 63, 18, 58, 32, 206, 204, 138, 132, 169, 165, 172, 34, 70, 32, 193, 186, 123, 248, 78, 222, 68, 214 },
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