using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace StudentMS.Web.Views
{
    public abstract class StudentMSRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected StudentMSRazorPage()
        {
            LocalizationSourceName = StudentMSConsts.LocalizationSourceName;
        }
    }
}
