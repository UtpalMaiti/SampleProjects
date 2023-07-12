using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using App,ALL.Configuration;
using App,ALL.Web;

namespace App,ALL.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class App,ALLDbContextFactory : IDesignTimeDbContextFactory<App,ALLDbContext>
    {
        public App,ALLDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<App,ALLDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            App,ALLDbContextConfigurer.Configure(builder, configuration.GetConnectionString(App,ALLConsts.ConnectionStringName));

            return new App,ALLDbContext(builder.Options);
        }
    }
}
