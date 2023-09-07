using System;
using System.Collections.Generic;
using Abp.Authorization.Users;
using Abp.Extensions;
using MalamuleleHealth.Domain;

namespace MalamuleleHealth.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Roles = new List<UserRole>()
            };

            user.SetNormalizedNames();

            return user;
        }


        /*//extending user

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<TestResult> TestResults { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<MedicalHistory> MedicalHistories { get; set; }*/
    }
}
