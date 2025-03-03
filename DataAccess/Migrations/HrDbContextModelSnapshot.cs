﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(HrDbContext))]
    partial class HrDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Concrete.AdvanceRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RequestApprovalStatusId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ResponseDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("AdvanceRequests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Currency = "₺",
                            Description = "Tatil",
                            EmployeeId = 2,
                            Price = 1000m,
                            RequestApprovalStatusId = 1,
                            RequestDate = new DateTime(2024, 2, 9, 3, 29, 49, 132, DateTimeKind.Local).AddTicks(3655),
                            Status = true,
                            Type = "Tatil"
                        },
                        new
                        {
                            Id = 2,
                            Currency = "₺",
                            Description = "2 maaş avans talebi",
                            EmployeeId = 2,
                            Price = 1000m,
                            RequestApprovalStatusId = 2,
                            RequestDate = new DateTime(2024, 2, 9, 3, 29, 49, 132, DateTimeKind.Local).AddTicks(3668),
                            Status = true,
                            Type = "Tatil"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.Firm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("ConctractEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ConctractStartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfFoundation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EmployeeCount")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("MersisNo")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("VergiDairesi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("VergiNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Firms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Kadıköy",
                            ConctractEndDate = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConctractStartDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfFoundation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bilgeadam@mail.com",
                            EmployeeCount = 100,
                            IsActive = true,
                            MersisNo = "1234567890123456",
                            Name = "Bilge Adam",
                            PhoneNumber = "05321234567",
                            Title = "Bilge Adam Bilişim Grubu",
                            VergiDairesi = "Kadıköy",
                            VergiNo = "1234567890"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Etiler",
                            ConctractEndDate = new DateTime(2032, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConctractStartDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfFoundation = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kocholding@mail.com",
                            EmployeeCount = 50000,
                            IsActive = true,
                            MersisNo = "1234567890123456",
                            Name = "Koç Holding",
                            PhoneNumber = "05321234597",
                            Title = "Koç Holding",
                            VergiDairesi = "Etiler",
                            VergiNo = "1234567891"
                        });
                });

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
                        },
                        new
                        {
                            Id = 3,
                            Name = "manager"
                        },
                        new
                        {
                            Id = 4,
                            Name = "empty"
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
                            Name = "Bekliyor"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Onay"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ret"
                        },
                        new
                        {
                            Id = 4,
                            Name = "İptal"
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

                    b.Property<byte[]>("Folder")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FolderName")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

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
                            RequestDate = new DateTime(2024, 2, 9, 3, 29, 49, 133, DateTimeKind.Local).AddTicks(2918),
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Currency = "₺",
                            EmployeeId = 1,
                            Name = "Yemek Gideri",
                            Price = 200m,
                            RequestApprovalStatusId = 2,
                            RequestDate = new DateTime(2024, 2, 9, 3, 29, 49, 133, DateTimeKind.Local).AddTicks(2926),
                            Status = true
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
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 3,
                            OperationClaimId = 3
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

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

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
                            RequestDate = new DateTime(2024, 2, 9, 3, 29, 49, 134, DateTimeKind.Local).AddTicks(859),
                            StartingDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            VocationLeaveTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 2,
                            EndingDate = new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RequestApprovalStatusId = 2,
                            RequestDate = new DateTime(2024, 2, 9, 3, 29, 49, 134, DateTimeKind.Local).AddTicks(867),
                            StartingDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
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
                            Name = "Yıllık İzin"
                        },
                        new
                        {
                            Id = 2,
                            Day = 5,
                            Name = "Hastalık İzni"
                        },
                        new
                        {
                            Id = 3,
                            Day = 3,
                            Name = "Evlilik İzni"
                        },
                        new
                        {
                            Id = 4,
                            Day = 120,
                            Name = "Doğum İzni"
                        },
                        new
                        {
                            Id = 5,
                            Day = 5,
                            Name = "Babalık İzni"
                        },
                        new
                        {
                            Id = 6,
                            Day = 3,
                            Name = "Ölüm İzni"
                        },
                        new
                        {
                            Id = 7,
                            Day = 1,
                            Name = "Ücretsiz İzin"
                        },
                        new
                        {
                            Id = 8,
                            Day = 1,
                            Name = "Diğer"
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
                            PasswordHash = new byte[] { 200, 141, 41, 74, 54, 165, 159, 7, 117, 88, 224, 13, 72, 39, 108, 16, 110, 214, 41, 222, 254, 107, 229, 178, 48, 170, 174, 127, 46, 102, 211, 161, 28, 140, 199, 163, 133, 123, 58, 156, 20, 136, 133, 90, 17, 92, 37, 96, 188, 149, 209, 247, 147, 73, 56, 148, 130, 40, 203, 54, 240, 49, 202, 181 },
                            PasswordSalt = new byte[] { 107, 230, 120, 242, 134, 244, 102, 28, 150, 173, 183, 204, 78, 26, 252, 130, 166, 39, 105, 105, 153, 104, 30, 175, 144, 81, 107, 242, 116, 59, 48, 0, 36, 70, 134, 201, 128, 172, 130, 181, 54, 188, 30, 51, 92, 216, 77, 122, 34, 49, 150, 146, 188, 9, 115, 72, 158, 66, 236, 64, 117, 120, 183, 34, 59, 224, 194, 197, 231, 180, 205, 94, 11, 90, 254, 35, 21, 48, 242, 164, 175, 50, 32, 100, 136, 252, 151, 50, 242, 177, 252, 99, 23, 109, 106, 7, 13, 185, 211, 42, 208, 178, 187, 133, 144, 90, 153, 249, 223, 118, 36, 124, 162, 251, 148, 60, 15, 50, 232, 133, 41, 212, 49, 63, 23, 72, 99, 121 },
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
                            PasswordHash = new byte[] { 229, 14, 247, 137, 85, 127, 18, 244, 222, 171, 136, 77, 128, 235, 185, 151, 99, 124, 214, 41, 107, 31, 65, 154, 154, 205, 181, 182, 134, 181, 247, 147, 128, 172, 30, 86, 157, 241, 55, 152, 167, 181, 120, 249, 236, 18, 243, 15, 66, 238, 226, 79, 142, 4, 104, 94, 153, 129, 117, 190, 48, 35, 235, 185 },
                            PasswordSalt = new byte[] { 220, 205, 12, 14, 118, 36, 252, 220, 134, 183, 165, 192, 61, 45, 115, 220, 148, 133, 56, 217, 142, 3, 220, 254, 7, 93, 196, 249, 58, 243, 12, 91, 138, 34, 42, 216, 24, 83, 1, 178, 229, 107, 77, 97, 151, 120, 198, 44, 155, 80, 155, 126, 79, 251, 88, 95, 48, 124, 45, 107, 51, 72, 121, 247, 28, 226, 182, 148, 117, 36, 184, 1, 190, 21, 19, 107, 137, 191, 115, 74, 185, 30, 252, 1, 6, 14, 135, 136, 240, 179, 104, 186, 140, 59, 120, 84, 115, 18, 161, 144, 205, 42, 163, 193, 61, 145, 3, 113, 24, 180, 150, 42, 14, 254, 39, 159, 49, 52, 20, 44, 204, 141, 254, 132, 254, 134, 28, 98 },
                            PhoneNumber = "05321234567",
                            Position = "Head of Department",
                            Profession = "Software Developer",
                            Salary = 10000m,
                            Status = true,
                            TitleId = 1,
                            TurkishIdentificationNumber = "12345678910"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Cevizlibağ",
                            BirthLocation = "İstanbul",
                            City = "İstanbul",
                            Company = "Bilge Adam",
                            DateOfBirth = new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfEmployment = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "IT",
                            Email = "mehmet.catmakasli@bilgeadamboost.com",
                            EmailForRegister = "mehmetcatmakasli@gmail.com",
                            FirstName = "Mehmet",
                            LastName = "Çatmakaşlı",
                            PasswordHash = new byte[] { 11, 176, 35, 207, 178, 101, 153, 39, 152, 87, 119, 199, 9, 32, 91, 76, 242, 189, 227, 168, 75, 140, 147, 101, 223, 236, 42, 77, 248, 1, 81, 21, 160, 143, 78, 92, 72, 225, 2, 147, 130, 88, 86, 89, 94, 231, 115, 35, 19, 123, 1, 178, 222, 22, 238, 69, 249, 69, 38, 8, 5, 164, 254, 36 },
                            PasswordSalt = new byte[] { 195, 135, 129, 79, 206, 27, 100, 72, 80, 52, 238, 111, 145, 75, 185, 49, 188, 213, 194, 185, 244, 161, 200, 233, 79, 119, 155, 137, 179, 138, 59, 67, 178, 235, 173, 149, 241, 121, 20, 55, 11, 1, 241, 60, 101, 21, 202, 73, 152, 223, 162, 64, 4, 144, 161, 123, 19, 108, 220, 205, 132, 208, 44, 12, 126, 41, 19, 126, 9, 229, 146, 11, 7, 119, 58, 145, 202, 170, 246, 212, 224, 84, 187, 198, 223, 197, 83, 163, 22, 30, 182, 136, 24, 183, 143, 203, 7, 121, 52, 76, 64, 246, 91, 54, 5, 243, 27, 15, 134, 234, 9, 154, 66, 119, 30, 48, 21, 105, 178, 178, 127, 40, 125, 139, 22, 235, 18, 30 },
                            PhoneNumber = "05321234567",
                            Position = "Junior Developer",
                            Profession = "Software Developer",
                            Salary = 15000m,
                            Status = true,
                            TitleId = 2,
                            TurkishIdentificationNumber = "14846942042"
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
