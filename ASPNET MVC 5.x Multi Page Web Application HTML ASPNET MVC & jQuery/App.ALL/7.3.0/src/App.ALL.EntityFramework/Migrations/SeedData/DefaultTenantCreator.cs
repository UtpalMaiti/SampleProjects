using System.Linq;
using App.ALL.EntityFramework;
using App.ALL.MultiTenancy;

namespace App.ALL.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ALLDbContext _context;

        public DefaultTenantCreator(ALLDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
