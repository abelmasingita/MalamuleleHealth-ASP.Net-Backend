using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Domain
{
    public class Bed
    {
        //[Required]
        [DisplayName("Bed Id")]
        public Guid Id { get; set; }

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
