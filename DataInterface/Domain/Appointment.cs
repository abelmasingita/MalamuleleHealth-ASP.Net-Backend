using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Domain
{
    public class Appointment
    {
        
        [DisplayName("Appointment Id")]
        public Guid AppointmentId { get; set; } 

        [DisplayName("Appointment Date")]
        public DateTime AppointmentDate { get; set; }

        [DisplayName("Appointment Time")]
        public DateTime AppointmentTime { get; set; }

        [DisplayName("Appointment Purpose")]
        public string Purpose { get; set; }

        [DisplayName("Appointment Status")]
        public string Status { get; set; }


        /*//relations
        [DisplayName("Patient")]
        [ForeignKey(nameof(DoctorId))]
        public User Doctor { get; set; }
        public long DoctorId { get; set; }

        [DisplayName("Doctor")]
        [ForeignKey(nameof(PatientId))]
        public User Patient { get; set; }
        public long PatientId { get; set; }*/
    }
}
