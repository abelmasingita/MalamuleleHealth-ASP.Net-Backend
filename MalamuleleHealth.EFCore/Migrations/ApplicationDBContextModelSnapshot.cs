﻿// <auto-generated />
using System;
using MalamuleleHealth.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MalamuleleHealth.EFCore.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataInterface.Domain.Appointment", b =>
                {
                    b.Property<Guid>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AppointmentTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppointmentId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("DataInterface.Domain.Bed", b =>
                {
                    b.Property<Guid>("BedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<Guid>("WardId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BedId");

                    b.HasIndex("WardId");

                    b.ToTable("Beds");
                });

            modelBuilder.Entity("DataInterface.Domain.Department", b =>
                {
                    b.Property<Guid>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DataInterface.Domain.Invoice", b =>
                {
                    b.Property<Guid>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TotalAmount")
                        .HasColumnType("real");

                    b.HasKey("InvoiceId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("DataInterface.Domain.MedicalHistory", b =>
                {
                    b.Property<Guid>("MedicalHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DiagnosisDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MedicalCondition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Treatment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicalHistoryId");

                    b.ToTable("MedicalHistories");
                });

            modelBuilder.Entity("DataInterface.Domain.MedicalTest", b =>
                {
                    b.Property<Guid>("MedicalTestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TestName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicalTestId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("MedicalTests");
                });

            modelBuilder.Entity("DataInterface.Domain.Message", b =>
                {
                    b.Property<Guid>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AppointmentTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("DataInterface.Domain.Payment", b =>
                {
                    b.Property<Guid>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DataInterface.Domain.Prescription", b =>
                {
                    b.Property<Guid>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AppointmentId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medication")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PrescriptionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("DataInterface.Domain.TestResult", b =>
                {
                    b.Property<Guid>("TestResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MedicalTestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ResultDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TestDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TestResultId");

                    b.HasIndex("MedicalTestId");

                    b.ToTable("TestResults");
                });

            modelBuilder.Entity("DataInterface.Domain.Ward", b =>
                {
                    b.Property<Guid>("WardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WardId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Wards");
                });

            modelBuilder.Entity("DataInterface.Domain.Bed", b =>
                {
                    b.HasOne("DataInterface.Domain.Ward", "Wards")
                        .WithMany()
                        .HasForeignKey("WardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wards");
                });

            modelBuilder.Entity("DataInterface.Domain.MedicalTest", b =>
                {
                    b.HasOne("DataInterface.Domain.Department", "Departments")
                        .WithMany("MedicalTests")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("DataInterface.Domain.Prescription", b =>
                {
                    b.HasOne("DataInterface.Domain.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("DataInterface.Domain.TestResult", b =>
                {
                    b.HasOne("DataInterface.Domain.MedicalTest", "MedicalTests")
                        .WithMany("TestResults")
                        .HasForeignKey("MedicalTestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalTests");
                });

            modelBuilder.Entity("DataInterface.Domain.Ward", b =>
                {
                    b.HasOne("DataInterface.Domain.Department", null)
                        .WithMany("Wards")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("DataInterface.Domain.Department", b =>
                {
                    b.Navigation("MedicalTests");

                    b.Navigation("Wards");
                });

            modelBuilder.Entity("DataInterface.Domain.MedicalTest", b =>
                {
                    b.Navigation("TestResults");
                });
#pragma warning restore 612, 618
        }
    }
}
