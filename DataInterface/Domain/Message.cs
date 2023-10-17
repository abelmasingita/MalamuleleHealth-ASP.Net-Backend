using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Domain
{
    public class Message
    {
        //[Required]
        [DisplayName("Message Id")]
        public Guid Id { get; set; }

        [DisplayName("Appointment Date")]
        public DateTime AppointmentDate { get; set; }

        [DisplayName("Appointment Time")]
        public DateTime AppointmentTime { get; set; }

        [DisplayName("Message Purpose")]
        public string Purpose { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }
    }
}
