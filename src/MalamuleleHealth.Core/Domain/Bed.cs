using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Domain
{
    public class Bed : FullAuditedEntity<Guid>
    {
        [Required]
        [DisplayName("Bed Number")]
        public int Number { get; set; }

        [DisplayName("Bed Availabilty")]
        public bool Availability { get; set; }


        //relationships

        [DisplayName("Ward")]
        public Guid WardId { get; set; }
        public Ward Wards { get; set; }
    }
}
