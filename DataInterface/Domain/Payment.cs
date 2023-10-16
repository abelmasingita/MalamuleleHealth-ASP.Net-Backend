using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Domain
{
    public class Payment
    {

        //[Required]
        [DisplayName("Payment Id")]
        public Guid PaymentId { get; set; }

        [DisplayName("Payment Amount")]
        public float Amount { get; set; }

        [DisplayName("Payment Date")]
        public DateTime PaymentDate { get; set; }


        //relationships
        public string PatientId { get; set; }

        [ForeignKey("PatientId")]
        public ApplicationUser Patient { get; set; }
    }
}
