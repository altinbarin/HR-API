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
    [Migration("20240208182036_claimchange")]
    partial class claimchange
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            RequestDate = new DateTime(2024, 2, 8, 21, 20, 36, 478, DateTimeKind.Local).AddTicks(771),
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
                            RequestDate = new DateTime(2024, 2, 8, 21, 20, 36, 478, DateTimeKind.Local).AddTicks(784),
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
                            RequestDate = new DateTime(2024, 2, 8, 21, 20, 36, 478, DateTimeKind.Local).AddTicks(9788),
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
                            RequestDate = new DateTime(2024, 2, 8, 21, 20, 36, 478, DateTimeKind.Local).AddTicks(9794),
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
                            RequestDate = new DateTime(2024, 2, 8, 21, 20, 36, 479, DateTimeKind.Local).AddTicks(7437),
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
                            RequestDate = new DateTime(2024, 2, 8, 21, 20, 36, 479, DateTimeKind.Local).AddTicks(7443),
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
                            PasswordHash = new byte[] { 147, 130, 44, 80, 250, 119, 15, 34, 32, 198, 82, 44, 155, 87, 240, 41, 203, 213, 29, 54, 66, 28, 37, 67, 210, 104, 164, 214, 20, 174, 176, 253, 33, 206, 124, 13, 83, 240, 131, 210, 207, 35, 82, 171, 215, 101, 62, 72, 83, 23, 9, 117, 137, 162, 103, 175, 28, 247, 98, 163, 64, 227, 152, 179 },
                            PasswordSalt = new byte[] { 9, 173, 204, 253, 224, 85, 64, 254, 39, 20, 100, 66, 44, 172, 127, 154, 230, 2, 137, 89, 26, 93, 180, 188, 121, 212, 218, 25, 195, 79, 167, 110, 27, 205, 81, 113, 33, 222, 72, 108, 169, 236, 213, 230, 107, 178, 38, 119, 175, 180, 170, 170, 50, 28, 151, 146, 220, 84, 80, 196, 27, 146, 159, 0, 152, 162, 74, 74, 21, 221, 18, 73, 53, 0, 132, 6, 218, 77, 59, 25, 82, 4, 53, 151, 125, 7, 66, 112, 70, 89, 108, 25, 127, 122, 5, 244, 91, 116, 33, 84, 27, 170, 138, 132, 148, 86, 114, 70, 73, 103, 94, 89, 57, 195, 253, 68, 122, 187, 180, 87, 196, 177, 161, 135, 133, 145, 228, 21 },
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
                            PasswordHash = new byte[] { 174, 102, 50, 168, 129, 127, 56, 47, 221, 159, 10, 252, 5, 253, 232, 102, 218, 88, 82, 252, 167, 165, 58, 6, 244, 94, 231, 79, 6, 191, 64, 93, 5, 184, 84, 162, 62, 42, 156, 90, 1, 44, 26, 224, 2, 165, 130, 139, 11, 20, 223, 56, 139, 199, 95, 22, 11, 155, 247, 6, 45, 251, 10, 60 },
                            PasswordSalt = new byte[] { 216, 135, 95, 69, 15, 73, 184, 68, 182, 199, 117, 149, 215, 110, 21, 188, 239, 22, 41, 222, 24, 125, 78, 250, 169, 70, 123, 17, 17, 138, 206, 95, 86, 213, 80, 123, 64, 91, 224, 101, 126, 164, 82, 195, 146, 240, 88, 168, 214, 128, 115, 226, 173, 8, 57, 120, 8, 15, 224, 242, 96, 207, 167, 98, 6, 47, 124, 39, 108, 144, 205, 63, 127, 92, 199, 29, 232, 73, 55, 74, 234, 151, 134, 150, 217, 85, 111, 123, 153, 129, 181, 204, 130, 148, 93, 200, 54, 11, 238, 82, 111, 105, 248, 79, 28, 57, 122, 245, 121, 92, 136, 207, 166, 187, 209, 50, 118, 129, 145, 59, 48, 148, 42, 153, 173, 254, 39, 192 },
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
                            PasswordHash = new byte[] { 90, 19, 157, 255, 253, 193, 89, 243, 103, 237, 102, 71, 128, 15, 92, 201, 229, 63, 151, 189, 11, 91, 210, 198, 147, 122, 224, 154, 10, 186, 223, 64, 65, 73, 136, 106, 123, 234, 35, 136, 118, 160, 189, 175, 242, 110, 240, 225, 95, 20, 190, 21, 23, 186, 175, 97, 80, 61, 234, 219, 90, 176, 215, 191 },
                            PasswordSalt = new byte[] { 136, 53, 86, 203, 40, 167, 190, 37, 219, 165, 10, 152, 171, 93, 61, 220, 120, 144, 200, 126, 241, 141, 213, 149, 152, 136, 128, 62, 85, 84, 169, 176, 17, 91, 69, 119, 218, 220, 221, 168, 249, 236, 192, 153, 167, 95, 80, 82, 135, 168, 172, 83, 167, 169, 166, 222, 65, 129, 53, 255, 156, 30, 97, 228, 103, 155, 118, 162, 37, 172, 167, 120, 134, 194, 87, 85, 157, 170, 0, 92, 239, 136, 189, 196, 157, 230, 140, 88, 204, 140, 252, 112, 198, 193, 65, 103, 228, 25, 254, 201, 142, 137, 73, 3, 181, 157, 59, 76, 152, 197, 253, 39, 251, 49, 135, 235, 144, 143, 160, 105, 33, 223, 111, 189, 46, 53, 234, 197 },
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
