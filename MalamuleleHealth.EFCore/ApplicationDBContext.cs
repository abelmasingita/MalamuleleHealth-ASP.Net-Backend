using DataInterface.Domain;
using MalamuleleHealth.EFCore.Application;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.EFCore
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<MedicalHistory> MedicalHistories { get; set; }
        public DbSet<MedicalTest> MedicalTests { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
        public DbSet<Ward> Wards { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Patient",
                    NormalizedName = "PATIENT"
                },
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
            );
            var department1 = Guid.NewGuid();
            var department2 = Guid.NewGuid();
            var appointment1 = Guid.NewGuid();
            var appointment2 = Guid.NewGuid();
            var medicalTest1 = Guid.NewGuid();
            var medicalTest2 = Guid.NewGuid();
            var ward1 = Guid.NewGuid();
            var ward2 = Guid.NewGuid();


            modelBuilder.Entity<Appointment>().HasData(
                    new Appointment
                    {
                        AppointmentId = appointment1,
                        AppointmentDate = DateTime.Now.Date,
                        AppointmentTime = DateTime.Now,
                        Purpose = "Regular checkup",
                        Status = "Scheduled",
                    },
                    new Appointment
                    {
                        AppointmentId = appointment2,
                        AppointmentDate = DateTime.Now.Date,
                        AppointmentTime = DateTime.Now,
                        Purpose = "Follow-up",
                        Status = "Scheduled",
                    }
            );
            modelBuilder.Entity<Bed>().HasData(
                        new Bed
                        {
                            BedId = Guid.NewGuid(),
                            Number = 101,
                            Availability = true,
                            WardId = ward1
                        },
                        new Bed
                        {
                            BedId = Guid.NewGuid(),
                            Number = 102,
                            Availability = false,
                            WardId = ward2,
                        }
            );
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    DepartmentId = department1,
                    Name = "Cardiology",
                    Description = "Heart-related issues",
                },
                new Department
                {
                    DepartmentId = department2,
                    Name = "Orthopedics",
                    Description = "Musculoskeletal disorders",
                }
            );
            modelBuilder.Entity<Invoice>().HasData(
                        new Invoice
                        {
                            InvoiceId = Guid.NewGuid(),
                            TotalAmount = 250.50f,
                            DueDate = DateTime.Now.Date.AddDays(30),
                            Status = "Pending",
                        },
                        new Invoice
                        {
                            InvoiceId = Guid.NewGuid(),
                            TotalAmount = 150.25f,
                            DueDate = DateTime.Now.Date.AddDays(15),
                            Status = "Paid",
                        }
             );

            modelBuilder.Entity<MedicalHistory>().HasData(
                new MedicalHistory
                {
                    MedicalHistoryId = Guid.NewGuid(),
                    DiagnosisDate = DateTime.Now.Date.AddMonths(-6),
                    MedicalCondition = "Hypertension",
                    Treatment = "Medication and lifestyle changes",
                },
                new MedicalHistory
                {
                    MedicalHistoryId = Guid.NewGuid(),
                    DiagnosisDate = DateTime.Now.Date.AddMonths(-12),
                    MedicalCondition = "Diabetes",
                    Treatment = "Insulin therapy",
                }
            );

            modelBuilder.Entity<MedicalTest>().HasData(
                    new MedicalTest
                    {
                        MedicalTestId = medicalTest1,
                        TestName = "Blood Pressure",
                        Cost = 45.00f,
                        DepartmentId = department1,
                    },
                    new MedicalTest
                    {
                        MedicalTestId = medicalTest2,
                        TestName = "X-Ray",
                        Cost = 120.50f,
                        DepartmentId = department2,
                    }
            );


            modelBuilder.Entity<Message>().HasData(
                    new Message
                    {
                        MessageId = Guid.NewGuid(),
                        AppointmentDate = DateTime.Now.Date.AddDays(2),
                        AppointmentTime = DateTime.Now,
                        Purpose = "Appointment Reminder",
                        Status = "Sent",
                    },
                    new Message
                    {
                        MessageId = Guid.NewGuid(),
                        AppointmentDate = DateTime.Now.Date.AddDays(3),
                        AppointmentTime = DateTime.Now,
                        Purpose = "Appointment Confirmation",
                        Status = "Sent",
                    }
            );

            modelBuilder.Entity<Payment>().HasData(
                    new Payment
                    {
                        PaymentId = Guid.NewGuid(),
                        Amount = 75.00f,
                        PaymentDate = DateTime.Now.Date.AddDays(-15),
                    },
                    new Payment
                    {
                        PaymentId = Guid.NewGuid(),
                        Amount = 100.25f,
                        PaymentDate = DateTime.Now.Date.AddDays(-30),
                    }
            );

            modelBuilder.Entity<Prescription>().HasData(
                   new Prescription
                   {
                       PrescriptionId = Guid.NewGuid(),
                       Medication = "Aspirin",
                       Instructions = "Take one tablet daily",
                       PrescriptionDate = DateTime.Now.Date.AddDays(-10),
                       AppointmentId = appointment1,
                   },
                   new Prescription
                    {
                        PrescriptionId = Guid.NewGuid(),
                        Medication = "Ibuprofen",
                        Instructions = "Take as needed for pain",
                        PrescriptionDate = DateTime.Now.Date.AddDays(-5),
                        AppointmentId = appointment2,
                    }
            );
            modelBuilder.Entity<TestResult>().HasData(
                  new TestResult
                  {
                      TestResultId = Guid.NewGuid(),
                      TestDate = DateTime.Now.Date.AddDays(-7),
                      ResultDetails = "Normal blood pressure reading",
                      MedicalTestId = medicalTest1,
                  },
                  new TestResult
                    {
                        TestResultId = Guid.NewGuid(),
                        TestDate = DateTime.Now.Date.AddDays(-3),
                        ResultDetails = "No fractures detected",
                        MedicalTestId = medicalTest2,
                    }
            );
            modelBuilder.Entity<Ward>().HasData(
                    new Ward
                    {
                        WardId = ward1,
                        Name = "General Ward",
                    },
                    new Ward
                    {
                        WardId = ward2,
                        Name = "Pediatrics Ward",
                    }
            );
        }

    }
}
