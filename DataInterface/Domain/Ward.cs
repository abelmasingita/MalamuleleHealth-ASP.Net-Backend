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
    public class Ward
    {
        //[Required]
        [DisplayName("Ward Id")]
        public Guid Id { get; set; }

        [Required]
        [DisplayName("Ward Name")]
        public string Name { get; set; }


        //relationships

        [ForeignKey("DepartmentId")]
        public Guid DepartmentId { get; set; }
        public Department Departments { get; set; }

        [DisplayName("Beds")]
        public ICollection<Bed> Beds { get; set; }
    }
}
