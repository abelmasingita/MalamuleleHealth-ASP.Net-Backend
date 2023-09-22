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
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {

        public void Configure(EntityTypeBuilder<Department> builder)
        {
            var configEnums = new ConfigEnums();

            builder.HasData(
                new Department
                {
                    DepartmentId = configEnums.department1,
                    Name = "Cardiology",
                    Description = "Heart-related issues",
                },
                new Department
                {
                    DepartmentId = configEnums.department2,
                    Name = "Orthopedics",
                    Description = "Musculoskeletal disorders",
                }
            );
        }
    }
}
