using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MalamuleleHealth.EntityFrameworkCore
{
    public static class MalamuleleHealthDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MalamuleleHealthDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MalamuleleHealthDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
