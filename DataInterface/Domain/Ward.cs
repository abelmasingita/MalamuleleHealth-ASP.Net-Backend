using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Domain
{
    public class Ward
    {
        //[Required]
        [DisplayName("Ward Id")]
        public Guid WardId { get; set; }

        [Required]
        [DisplayName("Ward Name")]
        public string Name { get; set; }
    }
}
