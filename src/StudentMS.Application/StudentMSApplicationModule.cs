using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using StudentMS.Authorization;

namespace StudentMS
{
    [DependsOn(
        typeof(StudentMSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class StudentMSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<StudentMSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(StudentMSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );

           
        }
    }
}
