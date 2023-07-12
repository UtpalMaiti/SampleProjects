using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using App,ALL.Authorization;

namespace App,ALL
{
    [DependsOn(
        typeof(App,ALLCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class App,ALLApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<App,ALLAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(App,ALLApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
