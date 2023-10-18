using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Domain
{
    public class Department
    {
        [DisplayName("Department Id")]
        public Guid Id { get; set; }
        [DisplayName("Department Name")]
        public string Name { get; set; }

        [DisplayName("Department Description")]
        public string Description { get; set; }



        //relationships
        [DisplayName("Wards")]
        public ICollection<Ward> Wards { get; set; }

        [DisplayName("Medical Tests")]
        public ICollection<MedicalTest> MedicalTests { get; set; }

        [DisplayName("Person")]
        public ICollection<User> ApplicationUsers { get; set; }
    }
}
