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
                     Name = "Yıllık İzin",
                     Day = 14
                 },
                 new VocationLeaveType
                 {
                     //Hastalık izni
                     Id = 2,
                     Name = "Hastalık İzni",
                     Day = 5
                 },
                 new VocationLeaveType
                 {
                     //evlilik izni
                     Id = 3,
                     Name = "Evlilik İzni",
                     Day = 3
                 },
                 new VocationLeaveType
                 {
                     //doğum izni
                     Id = 4,
                     Name = "Doğum İzni",
                     Day = 120
                 },
                 new VocationLeaveType
                 {
                     //babalık izni
                     Id = 5,
                     Name = "Babalık İzni",
                     Day = 5
                 },
                 new VocationLeaveType
                 {
                     //ölüm izni
                     Id = 6,
                     Name = "Ölüm İzni",
                     Day = 3
                 },
                  new VocationLeaveType
                  {
                      //ücretsiz izin
                      Id = 7,
                      Name = "Ücretsiz İzin",
                      Day = 1
                  },
                  new VocationLeaveType
                  {
                      //diğer izin
                      Id = 8,
                      Name = "Diğer",
                      Day = 1
                  }
                    );
        }
    }
}
