using System.ComponentModel;

namespace DataInterface.Configurations.Dto.Invoice
{
    public class InvoiceDto
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
    }
}
//DataInterface.Domain