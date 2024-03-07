using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Configurations.Dto.Specialities
{
    public class SpecialtyDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
