using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataInterface.Domain
{
    public class MedicalTest
    {
        //[Required]
        [DisplayName("MedicalTest Id")]
        public Guid Id { get; set; }

        [Required]
        [DisplayName("Medical Test Name")]
        public string TestName { get; set; }

        [DisplayName("Medical Test Cost")]
        public float Cost { get; set; }

        //relationships
        [DisplayName("Department")]
        public Guid DepartmentId { get; set; }
        public Department Departments { get; set; }
        public ICollection<TestResult> TestResults { get; set; }

    }
}
