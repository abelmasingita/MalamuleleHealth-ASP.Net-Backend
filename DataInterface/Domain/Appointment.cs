using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

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

        [DisplayName("Appointment Type")]
        public string Type { get; set; }

        //relations
        public ApplicationUser Patient { get; set; }
        public ApplicationUser Doctor { get; set; }
    }
}
