using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class TitleMap : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.HasData(
                new Title
                {
                    Id = 1,
                    Name = "Manager",
                },
                new Title
                {
                    Id = 2,
                    Name = "Software Developer",
                });
        }
    }
}
