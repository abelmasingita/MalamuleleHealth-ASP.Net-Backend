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
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {

        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            var configEnums = new ConfigEnums();

            builder.HasData(
                    new Payment
                    {
                        Id = Guid.NewGuid(),
                        Amount = 75.00f,
                        PaymentDate = DateTime.Now.Date.AddDays(-15),
                    },
                    new Payment
                    {
                        Id = Guid.NewGuid(),
                        Amount = 100.25f,
                        PaymentDate = DateTime.Now.Date.AddDays(-30),
                    }
            );
        }
    }
}
