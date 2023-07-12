using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using App,ALL.Configuration;

namespace App,ALL.Web.Host.Startup
{
    [DependsOn(
       typeof(App,ALLWebCoreModule))]
    public class App,ALLWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public App,ALLWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(App,ALLWebHostModule).GetAssembly());
        }
    }
}
