using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ALL.ALL.Authorization.Roles;
using ALL.ALL.Authorization.Users;
using ALL.ALL.MultiTenancy;

namespace ALL.ALL.EntityFrameworkCore
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
