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
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {

        public void Configure(EntityTypeBuilder<Message> builder)
        {
            var configEnums = new ConfigEnums();

            builder.HasData(
                    new Message
                    {
                        Id = Guid.NewGuid(),
                        AppointmentDate = DateTime.Now.Date.AddDays(2),
                        AppointmentTime = DateTime.Now,
                        Purpose = "Appointment Reminder",
                        Status = "Sent",
                    },
                    new Message
                    {
                        Id = Guid.NewGuid(),
                        AppointmentDate = DateTime.Now.Date.AddDays(3),
                        AppointmentTime = DateTime.Now,
                        Purpose = "Appointment Confirmation",
                        Status = "Sent",
                    }
            );
        }
    }
}
