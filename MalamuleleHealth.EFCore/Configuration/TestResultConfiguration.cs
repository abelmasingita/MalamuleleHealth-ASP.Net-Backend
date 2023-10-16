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
    public class TestResultConfiguration : IEntityTypeConfiguration<TestResult>
    {

        public void Configure(EntityTypeBuilder<TestResult> builder)
        {
            var configEnums = new ConfigEnums();

            builder.HasData(
                  new TestResult
                  {
                      TestResultId = Guid.NewGuid(),
                      TestDate = DateTime.Now.Date.AddDays(-7),
                      ResultDetails = "Normal blood pressure reading",
                      MedicalTestId = configEnums.medicalTest1,
                  },
                  new TestResult
                  {
                      TestResultId = Guid.NewGuid(),
                      TestDate = DateTime.Now.Date.AddDays(-3),
                      ResultDetails = "No fractures detected",
                      MedicalTestId = configEnums.medicalTest2,
                  }
            );
        }
    }
}
