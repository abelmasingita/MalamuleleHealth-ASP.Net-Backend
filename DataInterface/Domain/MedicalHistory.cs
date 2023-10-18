using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataInterface.Domain
{
    public class MedicalHistory
    {

        //[Required]
        [DisplayName("MedicalHistory Id")]
        public Guid Id { get; set; }

        [DisplayName("DiagnosisDate Date")]
        public DateTime DiagnosisDate { get; set; }

        [DisplayName("Medical Condition")]
        public string MedicalCondition { get; set; }

        [DisplayName("Treatment")]
        public string Treatment { get; set; }


        //relationships
        [Required(ErrorMessage = "Patient is Required")]
        public string PatientId { get; set; }
        public User Patient { get; set; }
    }
}
