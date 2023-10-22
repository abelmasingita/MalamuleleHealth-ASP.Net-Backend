using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Configurations.Dto.Department
{
    public class DepartmentDto
    {
        [DisplayName("Department Id")]
        public Guid Id { get; set; }
        [DisplayName("Department Name")]
        public string Name { get; set; }

        [DisplayName("Department Description")]
        public string Description { get; set; }
    }
}
