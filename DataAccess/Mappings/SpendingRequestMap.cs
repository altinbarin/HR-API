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
    public class SpendingRequestMap : IEntityTypeConfiguration<SpendingRequest>
    {
        public void Configure(EntityTypeBuilder<SpendingRequest> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Currency).HasMaxLength(20);
            

            builder.HasData(
                new SpendingRequest
                {
                    Id=1,
                    Name="Yakıt Gideri",
                    Price=500,
                    Currency= "₺",
                    EmployeeId=2,
                    RequestApprovalStatusId=1,
                },
                new SpendingRequest
                {
                    Id=2,
                    EmployeeId=1,
                    Name="Yemek Gideri",
                    Price=200,
                    Currency= "₺",
                    RequestApprovalStatusId=2
                });
        }
    }
}
