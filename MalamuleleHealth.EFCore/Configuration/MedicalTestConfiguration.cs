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
    public class MedicalTestConfiguration : IEntityTypeConfiguration<MedicalTest>
    {

        public void Configure(EntityTypeBuilder<MedicalTest> builder)
        {
            var configEnums = new ConfigEnums();

            builder.HasData(
                    new MedicalTest
                    {
                        Id = configEnums.medicalTest1,
                        TestName = "Blood Pressure",
                        Cost = 45.00f,
                        DepartmentId = configEnums.department1,
                    },
                    new MedicalTest
                    {
                        Id = configEnums.medicalTest2,
                        TestName = "X-Ray",
                        Cost = 120.50f,
                        DepartmentId = configEnums.department2,
                    }
            );
        }
    }
}
