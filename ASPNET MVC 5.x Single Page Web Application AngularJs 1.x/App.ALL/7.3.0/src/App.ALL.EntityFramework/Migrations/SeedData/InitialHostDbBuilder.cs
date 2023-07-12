using App.ALL.EntityFramework;
using EntityFramework.DynamicFilters;

namespace App.ALL.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ALLDbContext _context;

        public InitialHostDbBuilder(ALLDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
