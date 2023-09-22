using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Domain
{
    public class Invoice
    {
        //[Required]
        [DisplayName("Invoice Id")]
        public Guid InvoiceId { get; set; }

        [DisplayName("Invoice")]
        public float TotalAmount { get; set; }

        [DisplayName("Invoice Due Date")]
        public DateTime DueDate { get; set; }

        [DisplayName("Invoice Status")]
        public string Status { get; set; }


        public string PatientId { get; set; }

        [ForeignKey("PatientId")]
        public ApplicationUser Patient { get; set; }
    }
}
