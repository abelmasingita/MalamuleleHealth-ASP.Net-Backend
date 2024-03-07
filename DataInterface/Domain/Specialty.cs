using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Domain
{
    public class Specialty
    {
        [DisplayName("Speciality Id")]
        public Guid Id { get; set; }

        [Required]
        [DisplayName("Specialty Name")]
        public string Name { get; set; }
    }
}
