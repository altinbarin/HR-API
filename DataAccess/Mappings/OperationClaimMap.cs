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
                                              });
        }
    }
}
