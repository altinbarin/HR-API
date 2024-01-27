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
    public class VocationLeaveRequestMap :IEntityTypeConfiguration<VocationLeaveRequest>
    {
        public void Configure(EntityTypeBuilder<VocationLeaveRequest> builder)
        {
            builder.HasData(
                new VocationLeaveRequest
                {
                    Id = 1,
                    EmployeeId = 2,
                    VocationLeaveTypeId = 1,
                    RequestApprovalStatusId = 1,
                    StartingDate = new DateTime(2021, 1, 1),
                    EndingDate = new DateTime(2021, 1, 14),
                },
                new VocationLeaveRequest
                {
                    Id = 2,
                    EmployeeId = 2,
                    VocationLeaveTypeId = 2,
                    RequestApprovalStatusId = 2,
                    StartingDate = new DateTime(2022, 1, 1),
                    EndingDate = new DateTime(2022, 1, 14),
                });

        }
    }
}
