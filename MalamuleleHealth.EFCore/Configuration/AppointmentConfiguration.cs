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
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {

        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            var configEnums = new ConfigEnums();

            builder.HasData(
              new Appointment
              {
                  AppointmentId = configEnums.appointment1,
                  AppointmentDate = DateTime.Now.Date,
                  AppointmentTime = DateTime.Now,
                  Purpose = "Regular checkup",
                  Status = "Scheduled",
                  DoctorId = "1adec12d-3ac6-4fbb-ad08-bcb32f34b3b3",
                  PatientId = "5110a519-0720-453a-970f-9b4a9e8ee063"
              },
              new Appointment
              {
                  AppointmentId = configEnums.appointment2,
                  AppointmentDate = DateTime.Now.Date,
                  AppointmentTime = DateTime.Now,
                  Purpose = "Follow-up",
                  Status = "Scheduled",
                  DoctorId = "a9e42f48-56e0-482b-b630-3dcfe2ba1ce5",
                  PatientId = "5f2684a2-3f9f-422f-ba4c-6588e4c620b8"
              }
      );
        }
    }
}
