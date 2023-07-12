using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using App,ALL.Authorization.Roles;
using App,ALL.Authorization.Users;
using App,ALL.MultiTenancy;

namespace App,ALL.EntityFrameworkCore
{
    public class App,ALLDbContext : AbpZeroDbContext<Tenant, Role, User, App,ALLDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public App,ALLDbContext(DbContextOptions<App,ALLDbContext> options)
            : base(options)
        {
        }
    }
}
