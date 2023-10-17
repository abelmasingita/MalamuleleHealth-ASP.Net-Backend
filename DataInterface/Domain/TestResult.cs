﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Domain
{
    public class TestResult
    {
        //[Required]
        [DisplayName("TestResult Id")]
        public Guid Id { get; set; }

        [DisplayName("Test Date")]
        public DateTime TestDate { get; set; }

        [DisplayName("Result Details")]
        public string ResultDetails { get; set; }

        //relationships
        [DisplayName("Medical Test")]
        public Guid MedicalTestId { get; set; }
        public MedicalTest MedicalTests { get; set; }
        public ApplicationUser Patient { get; set; }

    }
}
