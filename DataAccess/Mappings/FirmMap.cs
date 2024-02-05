using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class FirmMap : IEntityTypeConfiguration<Firm>
    {
        public void Configure(EntityTypeBuilder<Firm> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.Title).HasMaxLength(100);
            builder.Property(e => e.MersisNo).HasMaxLength(16);
            builder.Property(e => e.VergiNo).HasMaxLength(10);
            builder.Property(e => e.VergiDairesi).HasMaxLength(100);
            builder.Property(e => e.PhoneNumber).HasMaxLength(11);
            builder.Property(e => e.Address).HasMaxLength(250);
            builder.Property(e => e.Email).HasMaxLength(100);



            builder.HasData(new Firm
            {
                Id = 1,
                Name = "Bilge Adam",
                Title = "Bilge Adam Bilişim Grubu",
                MersisNo = "1234567890123456",
                VergiNo = "1234567890",
                VergiDairesi = "Kadıköy",
                PhoneNumber = "05321234567",
                Address = "Kadıköy",
                Email = "bilgeadam@mail.com",
                EmployeeCount = 100,
                DateOfFoundation = new DateTime(2000, 01, 01),
                ConctractStartDate = new DateTime(2024, 01, 01),
                ConctractEndDate = new DateTime(2025, 01, 01),
                IsActive = true
            },
            new Firm
            {
                Id = 2,
                Name = "Koç Holding",
                Title = "Koç Holding",
                MersisNo = "1234567890123456",
                VergiNo = "1234567891",
                VergiDairesi = "Etiler",
                PhoneNumber = "05321234597",
                Address = "Etiler",
                Email = "kocholding@mail.com",
                EmployeeCount = 50000,
                DateOfFoundation = new DateTime(1980, 01, 01),
                ConctractStartDate = new DateTime(2024, 01, 01),
                ConctractEndDate = new DateTime(2032, 01, 01),
                IsActive = true
            });

        }
    }
}
