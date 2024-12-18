﻿using Abp.Authorization.Users;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using MalamuleleHealth.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Domain
{
    public class Appointment : FullAuditedEntity<Guid>
    {
        [DisplayName("Appointment Date")]
        public DateTime AppointmentDate { get; set; }

        [DisplayName("Appointment Time")]
        public DateTime AppointmentTime { get; set; }

        [DisplayName("Appointment Purpose")]
        public string Purpose { get; set; }

        [DisplayName("Appointment Status")]
        public string Status { get; set; }


        //relations
        [DisplayName("Patient")]
        [ForeignKey(nameof(DoctorId))]
        public User Doctor { get; set; }
        public long DoctorId { get; set; }

        [DisplayName("Doctor")]
        [ForeignKey(nameof(PatientId))]
        public User Patient { get; set; }
        public long PatientId { get; set; }
    }
}
