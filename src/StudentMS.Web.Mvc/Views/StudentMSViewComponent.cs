using Abp.AspNetCore.Mvc.ViewComponents;

namespace StudentMS.Web.Views
{
    public abstract class StudentMSViewComponent : AbpViewComponent
    {
        protected StudentMSViewComponent()
        {
            LocalizationSourceName = StudentMSConsts.LocalizationSourceName;
        }
    }
}
