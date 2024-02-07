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
                            RequestDate = new DateTime(2024, 2, 7, 2, 13, 5, 284, DateTimeKind.Local).AddTicks(4501),
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
                            RequestDate = new DateTime(2024, 2, 7, 2, 13, 5, 284, DateTimeKind.Local).AddTicks(4515),
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
                            RequestDate = new DateTime(2024, 2, 7, 2, 13, 5, 285, DateTimeKind.Local).AddTicks(3452),
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
                            RequestDate = new DateTime(2024, 2, 7, 2, 13, 5, 285, DateTimeKind.Local).AddTicks(3458),
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
                            RequestDate = new DateTime(2024, 2, 7, 2, 13, 5, 286, DateTimeKind.Local).AddTicks(924),
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
                            RequestDate = new DateTime(2024, 2, 7, 2, 13, 5, 286, DateTimeKind.Local).AddTicks(929),
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
                            PasswordHash = new byte[] { 29, 79, 175, 138, 48, 159, 72, 210, 209, 126, 16, 18, 194, 147, 32, 50, 62, 124, 49, 209, 236, 250, 162, 138, 94, 168, 184, 93, 196, 195, 212, 190, 194, 76, 195, 255, 109, 94, 13, 12, 160, 238, 158, 119, 179, 172, 239, 75, 0, 130, 56, 83, 104, 21, 191, 210, 235, 209, 157, 80, 222, 145, 82, 181 },
                            PasswordSalt = new byte[] { 156, 174, 8, 100, 39, 183, 61, 192, 79, 173, 140, 140, 67, 202, 24, 5, 239, 168, 86, 31, 112, 193, 168, 52, 8, 104, 186, 236, 134, 114, 133, 51, 107, 169, 159, 140, 56, 23, 217, 235, 70, 117, 21, 63, 226, 249, 254, 222, 75, 147, 213, 43, 204, 107, 24, 71, 59, 94, 59, 118, 16, 164, 135, 65, 120, 221, 173, 196, 48, 13, 44, 106, 102, 223, 115, 18, 27, 46, 239, 82, 141, 45, 76, 126, 143, 157, 129, 56, 4, 245, 17, 37, 123, 199, 249, 75, 115, 101, 26, 225, 40, 166, 99, 63, 58, 41, 10, 70, 198, 196, 162, 157, 31, 3, 45, 164, 16, 106, 160, 116, 122, 38, 31, 95, 62, 158, 208, 140 },
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
                            PasswordHash = new byte[] { 35, 120, 255, 13, 227, 233, 118, 236, 200, 19, 57, 254, 38, 51, 43, 69, 71, 179, 243, 175, 162, 32, 159, 252, 132, 32, 241, 217, 149, 201, 21, 95, 202, 67, 113, 55, 84, 155, 250, 115, 19, 182, 169, 157, 204, 72, 141, 226, 149, 80, 14, 34, 78, 135, 92, 156, 211, 126, 150, 86, 1, 66, 90, 250 },
                            PasswordSalt = new byte[] { 109, 131, 29, 105, 235, 143, 78, 77, 101, 136, 238, 149, 240, 40, 41, 23, 231, 7, 81, 172, 90, 208, 219, 27, 93, 221, 183, 38, 129, 107, 77, 87, 9, 124, 172, 172, 160, 233, 155, 152, 199, 166, 161, 49, 22, 111, 16, 219, 194, 10, 159, 20, 49, 134, 230, 167, 99, 18, 107, 70, 165, 190, 1, 75, 75, 102, 162, 95, 150, 162, 126, 134, 99, 250, 128, 67, 112, 149, 150, 245, 89, 205, 52, 44, 90, 158, 160, 190, 174, 201, 63, 163, 111, 192, 109, 84, 55, 65, 220, 137, 111, 135, 170, 157, 131, 223, 31, 21, 161, 19, 148, 185, 66, 19, 131, 119, 93, 165, 1, 243, 98, 217, 239, 133, 64, 245, 211, 170 },
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
                            PasswordHash = new byte[] { 131, 228, 134, 185, 20, 79, 33, 109, 119, 96, 70, 137, 250, 112, 21, 102, 17, 127, 117, 234, 44, 211, 251, 174, 165, 51, 78, 108, 127, 236, 197, 154, 82, 98, 53, 111, 213, 101, 89, 13, 8, 247, 219, 141, 163, 248, 91, 242, 102, 124, 15, 190, 42, 48, 32, 175, 14, 250, 161, 204, 237, 192, 38, 136 },
                            PasswordSalt = new byte[] { 180, 245, 55, 132, 51, 147, 130, 46, 3, 19, 68, 45, 236, 17, 196, 36, 202, 171, 233, 203, 166, 8, 215, 185, 186, 215, 127, 190, 229, 4, 179, 94, 76, 38, 91, 84, 163, 37, 79, 44, 252, 164, 82, 222, 83, 149, 13, 49, 197, 237, 171, 123, 128, 50, 47, 110, 14, 219, 200, 234, 224, 9, 214, 32, 140, 79, 61, 200, 102, 181, 231, 90, 46, 149, 53, 220, 27, 68, 169, 132, 126, 20, 201, 249, 203, 227, 162, 50, 58, 67, 251, 152, 58, 129, 85, 153, 65, 247, 65, 87, 117, 153, 209, 39, 208, 68, 142, 120, 192, 180, 214, 199, 251, 54, 153, 119, 244, 76, 214, 29, 231, 227, 17, 213, 176, 207, 98, 133 },
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
