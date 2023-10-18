using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Domain
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string IdNumber { get; set; }
        public string Address { get; set; }
        public string Specialist { get; set; }


        //relationships
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<TestResult> TestResults { get; set; }
    }
}



namespace DataInterface.Domain
{
    public enum Gender
    {
        Male,Female, Other
    }
}