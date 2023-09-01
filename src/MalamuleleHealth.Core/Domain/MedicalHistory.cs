using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Domain
{
    public class MedicalHistory : FullAuditedEntity<Guid>
    {

        [DisplayName("DiagnosisDate Date")]
        public DateTime DiagnosisDate { get; set; }

        [DisplayName("Medical Condition")]
        public string MedicalCondition { get; set; }

        [DisplayName("Treatment")]
        public string Treatment { get; set; }
    }
}
