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
    public class Invoice
    {
        //[Required]
        [DisplayName("Invoice Id")]
        public Guid Id { get; set; }

        [DisplayName("Invoice")]
        public float TotalAmount { get; set; }

        [DisplayName("Invoice Due Date")]
        public DateTime DueDate { get; set; }

        [DisplayName("Invoice Status")]
        public string Status { get; set; }


        //relationships
        [Required(ErrorMessage = "Patient is Required")]
        public string PatientId { get; set; }
        public User Patient { get; set; }
    }
}
