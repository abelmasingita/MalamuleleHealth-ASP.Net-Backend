using Abp.Domain.Entities.Auditing;
using MalamuleleHealth.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Domain
{
    public class Invoice : FullAuditedEntity<Guid>
    {
        [DisplayName("Invoice")]
        public decimal TotalAmount { get; set; }

        [DisplayName("Invoice Due Date")]
        public DateTime DueDate { get; set; }

        [DisplayName("Invoice Status")]
        public string Status { get; set; }


        public long PatientId { get; set; }
        [ForeignKey("PatientId")]
        public virtual User Patient { get; set; }
    }
}
