using Abp.Authorization.Users;
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
    public class Prescription : FullAuditedEntity<Guid>
    {
        [DisplayName("Medication")]
        public string Medication { get; set; }

        [DisplayName("Instructions")]
        public string Instructions { get; set; }

        [DisplayName("Prescription Date")]
        public DateTime PrescriptionDate { get; set; }

        [DisplayName("Appointment")]
        public Guid? AppointmentId { get; set; }
        [ForeignKey("AppointmentId")]
        public virtual Appointment Appointment { get; set; }

        [DisplayName("Responsible Doctor")]
        public long? DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public virtual User Doctor { get; set; }
    }
}
