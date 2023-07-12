using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using App,ALL.EntityFrameworkCore;
using App,ALL.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace App,ALL.Web.Tests
{
    [DependsOn(
        typeof(App,ALLWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class App,ALLWebTestModule : AbpModule
    {
        public App,ALLWebTestModule(App,ALLEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(App,ALLWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(App,ALLWebMvcModule).Assembly);
        }
    }
}