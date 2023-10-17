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
    public class PrescriptionConfiguration : IEntityTypeConfiguration<Prescription>
    {

        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            var configEnums = new ConfigEnums();

            builder.HasData(
                   new Prescription
                   {
                       Id = Guid.NewGuid(),
                       Medication = "Aspirin",
                       Instructions = "Take one tablet daily",
                       PrescriptionDate = DateTime.Now.Date.AddDays(-10),
                       AppointmentId = configEnums.appointment1,
                      
                   },
                   new Prescription
                   {
                       Id = Guid.NewGuid(),
                       Medication = "Ibuprofen",
                       Instructions = "Take as needed for pain",
                       PrescriptionDate = DateTime.Now.Date.AddDays(-5),
                       AppointmentId = configEnums.appointment2,
                      
                   }
            );
        }
    }
}
