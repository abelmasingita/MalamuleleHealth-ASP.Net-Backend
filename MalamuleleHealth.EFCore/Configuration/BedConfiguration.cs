using DataInterface.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.EFCore.Configuration
{
    public class BedConfiguration : IEntityTypeConfiguration<Bed>
    {

        public void Configure(EntityTypeBuilder<Bed> builder)
        {
            var configEnums = new ConfigEnums();

            builder.HasData(
                        new Bed
                        {
                            Id = Guid.NewGuid(),
                            Number = 101,
                            Availability = true,
                            WardId = configEnums.ward1
                        },
                        new Bed
                        {
                            Id = Guid.NewGuid(),
                            Number = 102,
                            Availability = false,
                            WardId = configEnums.ward2,
                        }


          );
        }
    }
}
