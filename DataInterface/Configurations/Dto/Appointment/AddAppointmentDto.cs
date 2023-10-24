using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Configurations.Dto.Appointment
{
    public class AddAppointmentDto
    {

        [DisplayName("Appointment Date")]
        public DateTime AppointmentDate { get; set; }

        [DisplayName("Appointment Time")]
        public DateTime AppointmentTime { get; set; }

        [DisplayName("Appointment Purpose")]
        public string Purpose { get; set; }

        [DisplayName("Appointment Status")]
        public string Status { get; set; }

        [DisplayName("Appointment Type")]
        public string Type { get; set; }

        //relationships
        [Required(ErrorMessage = "Patient is Required")]
        public string PatientId { get; set; }

        [Required(ErrorMessage = "Doctor is Required")]
        public string DoctorId { get; set; }
    }
}
