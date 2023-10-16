using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
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
    }
}



namespace DataInterface.Domain
{
    public enum Gender
    {
        Male,Female, Other
    }
}