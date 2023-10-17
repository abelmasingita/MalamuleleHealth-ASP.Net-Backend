using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Domain
{
    public class Prescription
    {
        //[Required]
        [DisplayName("Prescription Id")]
        public Guid Id { get; set; }

        [DisplayName("Medication")]
        public string Medication { get; set; }

        [DisplayName("Instructions")]
        public string Instructions { get; set; }

        [DisplayName("Prescription Date")]
        public DateTime PrescriptionDate { get; set; }


        //relationships
        [DisplayName("Appointment")]
        public Guid AppointmentId { get; set; }

        [ForeignKey("AppointmentId")]
        public virtual Appointment Appointment { get; set; }

        public string DoctorId { get; set; }
        public ApplicationUser Doctor { get; set; }
    }
}
