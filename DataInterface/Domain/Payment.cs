using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataInterface.Domain
{
    public class Payment
    {

        //[Required]
        [DisplayName("Payment Id")]
        public Guid Id { get; set; }

        [DisplayName("Payment Amount")]
        public float Amount { get; set; }

        [DisplayName("Payment Date")]
        public DateTime PaymentDate { get; set; }


        //relationships
        [Required(ErrorMessage = "Patient is Required")]
        public string PatientId { get; set; }
        public User Patient { get; set; }
    }
}
