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
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string IdNumber { get; set; }
        public string Address { get; set; }
        public string Specialist { get; set; }


        //relationships
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public ICollection<TestResult> TestResults { get; set; }
    }
}



namespace DataInterface.Domain
{
    public enum Gender
    {
        Male,Female, Other
    }
}