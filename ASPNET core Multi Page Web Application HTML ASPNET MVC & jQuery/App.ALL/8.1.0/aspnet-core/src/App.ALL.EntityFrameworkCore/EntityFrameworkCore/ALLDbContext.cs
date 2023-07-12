using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using App.ALL.Authorization.Roles;
using App.ALL.Authorization.Users;
using App.ALL.MultiTenancy;

namespace App.ALL.EntityFrameworkCore
{
    public class ALLDbContext : AbpZeroDbContext<Tenant, Role, User, ALLDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ALLDbContext(DbContextOptions<ALLDbContext> options)
            : base(options)
        {
        }
    }
}
