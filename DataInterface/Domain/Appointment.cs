using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataInterface.Domain
{
    public class Appointment
    {

        [DisplayName("Appointment Id")]
        public Guid Id { get; set; }

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
