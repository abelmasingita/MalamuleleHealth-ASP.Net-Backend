using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Configurations.Dto.User
{
    public class UpdateUserRoleDto
    {
        public string UserId { get; set; }
        public string NewRole { get; set; }
    }
}
