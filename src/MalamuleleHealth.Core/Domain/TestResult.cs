using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Domain
{
    public class TestResult : FullAuditedEntity<Guid>
    {

        [DisplayName("Test Date")]
        public DateTime TestDate { get; set; }

        [DisplayName("Result Details")]
        public string ResultDetails { get; set; }

        //relationships
        [DisplayName("Medical Test")]
        public Guid MedicalTestId { get; set; }
        public MedicalTest MedicalTests { get; set; }

    }
}
