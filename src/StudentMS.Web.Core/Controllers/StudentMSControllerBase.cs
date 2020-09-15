using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace StudentMS.Controllers
{
    public abstract class StudentMSControllerBase: AbpController
    {
        protected StudentMSControllerBase()
        {
            LocalizationSourceName = StudentMSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
