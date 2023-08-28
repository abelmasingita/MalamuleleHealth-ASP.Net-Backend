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
    public class Prescription : FullAuditedEntity<long>
    {
        [DisplayName("Medication")]
        public string Medications { get; set; }

        [DisplayName("Instructions")]
        public string Instructions { get; set; }

        [DisplayName("Prescription Date")]
        public DateTime PrescriptionDate { get; set; }

        [DisplayName("Appointment")]
        public long? AppointmentID { get; set; }
        [ForeignKey("AppointmentID")]
        public virtual Appointment Appointment { get; set; }

        [DisplayName("Doctor")]
        public long? DoctorID { get; set; }
        [ForeignKey("DoctorID")]
        public virtual UserRole Doctor { get; set; }
    }
}
