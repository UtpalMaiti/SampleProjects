using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using App.ALL.EntityFramework;

namespace App.ALL.Migrator
{
    [DependsOn(typeof(ALLDataModule))]
    public class ALLMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ALLDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}