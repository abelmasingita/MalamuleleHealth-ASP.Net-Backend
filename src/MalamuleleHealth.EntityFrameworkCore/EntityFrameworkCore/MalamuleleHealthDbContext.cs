using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MalamuleleHealth.Authorization.Roles;
using MalamuleleHealth.Authorization.Users;
using MalamuleleHealth.MultiTenancy;

namespace MalamuleleHealth.EntityFrameworkCore
{
    public class MalamuleleHealthDbContext : AbpZeroDbContext<Tenant, Role, User, MalamuleleHealthDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MalamuleleHealthDbContext(DbContextOptions<MalamuleleHealthDbContext> options)
            : base(options)
        {
        }
    }
}
