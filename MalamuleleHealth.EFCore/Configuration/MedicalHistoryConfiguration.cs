﻿using DataInterface.Domain;
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
    public class MedicalHistoryConfiguration : IEntityTypeConfiguration<MedicalHistory>
    {

        public void Configure(EntityTypeBuilder<MedicalHistory> builder)
        {
            var configEnums = new ConfigEnums();

            builder.HasData(
                new MedicalHistory
                {
                    MedicalHistoryId = Guid.NewGuid(),
                    DiagnosisDate = DateTime.Now.Date.AddMonths(-6),
                    MedicalCondition = "Hypertension",
                    Treatment = "Medication and lifestyle changes",
                   
                    PatientId = "5110a519-0720-453a-970f-9b4a9e8ee063"
                },
                new MedicalHistory
                {
                    MedicalHistoryId = Guid.NewGuid(),
                    DiagnosisDate = DateTime.Now.Date.AddMonths(-12),
                    MedicalCondition = "Diabetes",
                    Treatment = "Insulin therapy",
                 
                    PatientId = "5110a519-0720-453a-970f-9b4a9e8ee063"
                }
            );
        }
    }
}