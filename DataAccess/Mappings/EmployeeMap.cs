using Core.Utilities.Security.Hashing;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;

namespace DataAccess.Mappings
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {


            builder.Property(e=>e.Address).HasMaxLength(250);
            builder.Property(e => e.BirthLocation).HasMaxLength(100);
            builder.Property(e => e.Department).HasMaxLength(100);
            builder.Property(e => e.FirstName).HasMaxLength(50);
            builder.Property(e => e.LastName).HasMaxLength(50);
            builder.Property(e => e.Profession).HasMaxLength(100);
            builder.Property(e => e.TurkishIdentificationNumber).HasMaxLength(11);
            //builder.Property(e => e.PhoneNumber).HasMaxLength(11);
            builder.Property(e => e.Salary).HasColumnType("decimal(18,2)");
            builder.Property(e => e.PasswordHash).HasColumnType("varbinary(500)");
            builder.Property(e => e.PasswordSalt).HasColumnType("varbinary(500)");
            builder.Property(e => e.Status).HasDefaultValue(true);



            var furkan = new Employee
            {
                Id = 1,
                Address = "Kadıköy",
                EmailForRegister = "furkanaltinbarin@gmail.com",
                City = "İstanbul",
                Company = "Bilge Adam",
                Department = "IT",
                FirstName = "Furkan",
                LastName = "Altınbarın",
                PhoneNumber = "05321234567",
                Salary = 10000,
                Position = "Head of Department",
                DateOfBirth = new DateTime(1997, 11, 11),
                TurkishIdentificationNumber = "12345678910",
                DateOfEmployment = new DateTime(2021, 01, 01),
                Status = true,
                TitleId = 1,
                BirthLocation = "İstanbul",
                Profession = "Software Developer",
                //Title = new Title
                //{
                //    Id = 1,
                //    Name = "Manager",
                //},
            };

            HashingHelper.CreatePasswordHash("123", out byte[] passwordHash1, out byte[] passwordSalt1);
            furkan.PasswordHash = passwordHash1;
            furkan.PasswordSalt = passwordSalt1;



            var hakan = new Employee
            {
                Id = 2,
                Address = "Kartal",
                EmailForRegister = "hakantoraman@gmail.com",
                City = "İstanbul",
                Company = "Bilge Adam",
                Department = "IT",
                FirstName = "Hakan",
                LastName = "Toraman",
                PhoneNumber = "05321234567",
                Salary = 10000,
                Position = "Junior Developer",
                DateOfBirth = new DateTime(1995, 11, 11),
                TurkishIdentificationNumber = "12345678910",
                DateOfEmployment = new DateTime(2021, 01, 01),
                Status = true,
                TitleId = 2,
                BirthLocation = "İstanbul",
                Profession = "Software Developer",
                //Title = new Title
                //{
                //    Id = 2,
                //    Name = "Software Developer",
                //}
            };
            HashingHelper.CreatePasswordHash("123", out byte[] passwordHash, out byte[] passwordSalt);
            hakan.PasswordHash = passwordHash;
            hakan.PasswordSalt = passwordSalt;


            



            builder.HasData(
                hakan,
                furkan
                );
        }
    }
}
