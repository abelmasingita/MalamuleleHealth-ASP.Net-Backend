using Abp.Authorization.Users;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
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

        [DisplayName("Patient")]
        public  long? PatientID { get; set; }
        [ForeignKey("PatientID")]
        public virtual UserRole Patient { get; set; }

        [DisplayName("Responsible Doctor")]
        public long? DoctorID { get; set; }
        [ForeignKey("DoctorID")]
        public virtual UserRole Doctor { get; set; }
    }
}
