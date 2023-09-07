using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MalamuleleHealth.Authorization.Roles;
using MalamuleleHealth.Authorization.Users;
using MalamuleleHealth.MultiTenancy;
using MalamuleleHealth.Domain;
using System;

namespace MalamuleleHealth.EntityFrameworkCore
{
    public class MalamuleleHealthDbContext : AbpZeroDbContext<Tenant, Role, User, MalamuleleHealthDbContext>
    {
        public static class RoleNames
        {
            public const string Doctor = "Doctor";
            public const string Nurse = "Nurse";
            public const string Patient = "Patient";
            public const string Pharmacist = "Pharmacist";
            public const string LabTechnician = "Lab Technician";
        }

        /* Define a DbSet for each entity of the application */

        public MalamuleleHealthDbContext(DbContextOptions<MalamuleleHealthDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed roles
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = RoleNames.Doctor, DisplayName = "Doctor", IsStatic = true, IsDefault = false },
                new Role { Id = 2, Name = RoleNames.Nurse, DisplayName = "Nurse", IsStatic = true, IsDefault = false },
                new Role { Id = 3, Name = RoleNames.Patient, DisplayName = "Patient", IsStatic = true, IsDefault = false },
                new Role { Id = 4, Name = RoleNames.Pharmacist, DisplayName = "Pharmacist", IsStatic = true, IsDefault = false },
                new Role { Id = 5, Name = RoleNames.LabTechnician, DisplayName = "Lab Technician", IsStatic = true, IsDefault = false }
            // Add more roles as needed
            );

        }

        public DbSet<Prescription> Departments { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        /*public DbSet<Bed> Beds { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<MedicalHistory> MedicalHistories { get; set; }
        public DbSet<MedicalTest> MedicalTests { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<TestResult> TestResults { get; set; }*/

    }

}
