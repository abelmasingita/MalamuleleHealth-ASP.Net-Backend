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
    public class WardConfiguration : IEntityTypeConfiguration<Ward>
    {

        public void Configure(EntityTypeBuilder<Ward> builder)
        {
            var configEnums = new ConfigEnums();

            builder.HasData(
                    new Ward
                    {
                        Id = configEnums.ward1,
                        Name = "General Ward",
                    },
                    new Ward
                    {
                        Id = configEnums.ward2,
                        Name = "Pediatrics Ward",
                    }
            );
        }
    }
}
