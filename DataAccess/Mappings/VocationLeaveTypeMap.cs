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
    public class VocationLeaveTypeMap : IEntityTypeConfiguration<VocationLeaveType>
    {
        public void Configure(EntityTypeBuilder<VocationLeaveType> builder)
        {
            builder.HasData(
                 new VocationLeaveType
                 {
                     //Yıllık izin
                     Id = 1,
                     Name = "Annual Leave",
                     Day = 14
                 },
                 new VocationLeaveType
                 {
                     //Hastalık izni
                     Id = 2,
                     Name = "Sick Leave",
                     Day = 5
                 },
                 new VocationLeaveType
                 {
                     //evlilik izni
                     Id = 3,
                     Name = "Marriage Leave",
                     Day = 3
                 },
                 new VocationLeaveType
                 {
                     //doğum izni
                     Id = 4,
                     Name = "Maternity Leave",
                     Day = 120
                 },
                 new VocationLeaveType
                 {
                     //babalık izni
                     Id = 5,
                     Name = "Paternity Leave",
                     Day = 5
                 },
                 new VocationLeaveType
                 {
                     //ölüm izni
                     Id = 6,
                     Name = "Bereavement Leave",
                     Day = 3
                 },
                  new VocationLeaveType
                  {
                      //ücretsiz izin
                      Id = 7,
                      Name = "Unpaid Leave",
                      Day = 1
                  },
                  new VocationLeaveType
                  {
                      //diğer izin
                      Id = 8,
                      Name = "Other",
                      Day = 1
                  }
                    );
        }
    }
}
