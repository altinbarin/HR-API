using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class RequestApprovalStatusMap : IEntityTypeConfiguration<RequestApprovalStatus>
    {
        public void Configure(EntityTypeBuilder<RequestApprovalStatus> builder)
        {

            builder.Property(e => e.Name).HasMaxLength(50);

            builder.HasData(
                               new RequestApprovalStatus
                               {
                                   Id = 1,
                                   Name = "Bekliyor"
                               },
                                              new RequestApprovalStatus
                                              {
                                                  Id = 2,
                                                  Name = "Onay"
                                              },
                                                             new RequestApprovalStatus
                                                             {
                                                                 Id = 3,
                                                                 Name = "Ret"
                                                             },
                                                                        new RequestApprovalStatus
                                                                        {
                                                                            Id = 4,
                                                                            Name = "İptal"
                                                                        }
                                                                            );
        }
    }
}
