
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace StudentMS.Web.Controllers
{
    [DependsOn(
       typeof(StudentMSApplicationModule),
       typeof(AbpHttpClientModule)
   )]
    public class StudentMSHttpAPIClientModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(typeof(StudentMS.StudentMSApplicationModule).Assembly);
        }
    }
}
