using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Configurations.Dto.Appointment
{
    public class AppointmentDto
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
    }
}
