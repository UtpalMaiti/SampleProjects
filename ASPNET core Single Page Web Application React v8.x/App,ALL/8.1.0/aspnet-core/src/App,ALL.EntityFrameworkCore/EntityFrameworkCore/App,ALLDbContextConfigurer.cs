using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace App,ALL.EntityFrameworkCore
{
    public static class App,ALLDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<App,ALLDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<App,ALLDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
