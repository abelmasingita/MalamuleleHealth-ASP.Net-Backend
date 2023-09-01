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
    public class MedicalTest : FullAuditedEntity<Guid>
    {
        [Required]
        [DisplayName("Medical Test Name")]
        public string TestName { get; set; }

        [DisplayName("Medical Test Cost")]
        public double Cost { get; set; }

        //relationships
        [DisplayName("Department")]
        public Guid DepartmentId { get; set; }
        public Department Departments { get; set; }

        public ICollection<TestResult> TestResults { get; set; }
    }
}
