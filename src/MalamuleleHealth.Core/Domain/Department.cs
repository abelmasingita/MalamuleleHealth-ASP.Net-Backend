using Abp.Domain.Entities;
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
    public class Department : FullAuditedEntity<Guid>
    {
        [Required]
        [DisplayName("Department Name")]
        public string Name { get; set; }

        [DisplayName("Department Description")]
        public string Description { get; set; }
    }
}
