using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Configurations.Dto.Ward
{
    public class AddWardDto
    {
        public string Name { get; set; }
        public string DepartmentId { get; set; }
    }
}
