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
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {

        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            var configEnums = new ConfigEnums();

            builder.HasData(
                        new Invoice
                        {
                            InvoiceId = Guid.NewGuid(),
                            TotalAmount = 250.50f,
                            DueDate = DateTime.Now.Date.AddDays(30),
                            Status = "Pending",                    
                            PatientId = "5110a519-0720-453a-970f-9b4a9e8ee063"

                        },
                        new Invoice
                        {
                            InvoiceId = Guid.NewGuid(),
                            TotalAmount = 150.25f,
                            DueDate = DateTime.Now.Date.AddDays(15),
                            Status = "Paid",                          
                            PatientId = "5110a519-0720-453a-970f-9b4a9e8ee063"
                        }
             );
        }
    }
}
