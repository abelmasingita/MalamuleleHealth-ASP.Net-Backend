using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MalamuleleHealth.Controllers
{
    public abstract class MalamuleleHealthControllerBase: AbpController
    {
        protected MalamuleleHealthControllerBase()
        {
            LocalizationSourceName = MalamuleleHealthConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
