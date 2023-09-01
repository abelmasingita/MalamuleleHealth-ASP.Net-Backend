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
    public class Ward : FullAuditedEntity<Guid>
    {
        [Required]
        [DisplayName("Ward Name")]
        public string Name { get; set; }


        //relationships
        [DisplayName("Department")]
        public Guid DepartmentId { get; set; }
        public Department Departments { get; set; }

        [DisplayName("Beds")]
        public ICollection<Bed> Beds { get; set; }
    }
}
