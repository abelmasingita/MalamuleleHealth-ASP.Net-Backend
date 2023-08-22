using Abp.Authorization;
using MalamuleleHealth.Authorization.Roles;
using MalamuleleHealth.Authorization.Users;

namespace MalamuleleHealth.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
