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
    public class UserOperationClaimMap :IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.HasData(
               new UserOperationClaim
               {
                   Id = 1,
                   EmployeeId = 1,
                   OperationClaimId = 1
               },
               new UserOperationClaim
               {
                   Id = 2,
                   EmployeeId = 2,
                   OperationClaimId = 2
               },
               new UserOperationClaim
               {
                   Id=3,
                   EmployeeId=3,
                   OperationClaimId=3
               });
        }
    }
}
