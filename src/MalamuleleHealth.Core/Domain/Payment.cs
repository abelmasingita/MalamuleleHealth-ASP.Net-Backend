using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Domain
{
    public class Payment : FullAuditedEntity<Guid>
    {
        [DisplayName("Payment Amount")]
        public decimal Amount { get; set; }

        [DisplayName("Payment Date")]
        public DateTime PaymentDate { get; set; }
    }
}
