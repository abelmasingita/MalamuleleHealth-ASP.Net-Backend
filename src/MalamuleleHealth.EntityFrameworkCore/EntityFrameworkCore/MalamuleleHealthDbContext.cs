using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MalamuleleHealth.Authorization.Roles;
using MalamuleleHealth.Authorization.Users;
using MalamuleleHealth.MultiTenancy;
using MalamuleleHealth.Domain;

namespace MalamuleleHealth.EntityFrameworkCore
{
    public class MalamuleleHealthDbContext : AbpZeroDbContext<Tenant, Role, User, MalamuleleHealthDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public MalamuleleHealthDbContext(DbContextOptions<MalamuleleHealthDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }    
        public DbSet<Appointment> Appointments { get; set; }    
        public DbSet<Prescription> Prescriptions { get; set; }    
    }
}
