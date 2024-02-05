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
    public class AdvanceRequestMap : IEntityTypeConfiguration<AdvanceRequest>
    {
        public void Configure(EntityTypeBuilder<AdvanceRequest> builder)
        {

            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Currency).HasMaxLength(10);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.Type).HasMaxLength(50);


            builder.HasData(
                   new AdvanceRequest
                   {
                       Id = 1,
                       EmployeeId = 2,
                       RequestApprovalStatusId = 1,
                       Price = 1000,
                       Currency = "₺",
                       Description = "Tatil",
                       Type = "Tatil"
                   },
                    new AdvanceRequest
                    {
                        Id = 2,
                        EmployeeId = 2,
                        RequestApprovalStatusId = 2,
                        Price = 1000,
                        Currency = "₺",
                        Description = "2 maaş avans talebi",
                        Type = "Tatil"
                    });
        }
    }
}
