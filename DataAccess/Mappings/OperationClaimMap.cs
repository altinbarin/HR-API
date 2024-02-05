using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings
{
    public class OperationClaimMap : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.HasData(
                               new OperationClaim
                               {
                                   Id = 1,
                                   Name = "admin"
                               },
                                new OperationClaim
                                {
                                    Id = 2,
                                    Name = "user"
                                },
                                new OperationClaim
                                {
                                    Id = 3,
                                    Name = "manager"
                                });
        }
    }
}
