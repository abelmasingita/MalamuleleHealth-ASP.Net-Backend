using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MalamuleleHealth.EFCore.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentDate", "AppointmentTime", "Purpose", "Status" },
                values: new object[,]
                {
                    { new Guid("56b55b08-1d99-40c3-a6d7-30b1343a27b0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 12, 51, 2, 428, DateTimeKind.Local).AddTicks(5142), "Follow-up", "Scheduled" },
                    { new Guid("a896f84a-1ed1-44ac-8e39-cf702cb29123"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 12, 51, 2, 428, DateTimeKind.Local).AddTicks(5139), "Regular checkup", "Scheduled" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("6f93cd11-ea0a-4233-837b-d84ed61b0b1a"), "Heart-related issues", "Cardiology" },
                    { new Guid("d9421643-354c-4c92-8e8a-0cceb9f58424"), "Musculoskeletal disorders", "Orthopedics" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "DueDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("182ce1f4-0a6b-47c5-9978-039d77b27da6"), new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Paid", 150.25f },
                    { new Guid("781cd3e2-e4e9-40c3-a6ea-2f31df6996a1"), new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Pending", 250.5f }
                });

            migrationBuilder.InsertData(
                table: "MedicalHistories",
                columns: new[] { "MedicalHistoryId", "DiagnosisDate", "MedicalCondition", "Treatment" },
                values: new object[,]
                {
                    { new Guid("c636ff57-7816-4c8d-a56c-47a6d872487e"), new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "Diabetes", "Insulin therapy" },
                    { new Guid("e52b9e22-4e02-4a94-adf2-1f35a0c389d9"), new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Hypertension", "Medication and lifestyle changes" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "AppointmentDate", "AppointmentTime", "Purpose", "Status" },
                values: new object[,]
                {
                    { new Guid("921441db-06e1-486f-876e-ab82cb1ca6b4"), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 12, 51, 2, 428, DateTimeKind.Local).AddTicks(5455), "Appointment Reminder", "Sent" },
                    { new Guid("aec6b6f9-ab5d-44b4-9a6f-776a935b9a79"), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 12, 51, 2, 428, DateTimeKind.Local).AddTicks(5459), "Appointment Confirmation", "Sent" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "PaymentDate" },
                values: new object[,]
                {
                    { new Guid("08e352e2-281d-4123-8d33-1ab9db276722"), 75f, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ad12dcef-8a24-4c6e-83ff-42f2831b8fb4"), 100.25f, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Wards",
                columns: new[] { "WardId", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { new Guid("01d2950a-d07e-4342-8c05-eae2a9e802c6"), null, "General Ward" },
                    { new Guid("25204199-e961-4eb6-b2e9-781eb9054d14"), null, "Pediatrics Ward" }
                });

            migrationBuilder.InsertData(
                table: "Beds",
                columns: new[] { "BedId", "Availability", "Number", "WardId" },
                values: new object[,]
                {
                    { new Guid("6ba62bd3-ab14-4bdd-94b9-6bb91b14b6c0"), false, 102, new Guid("25204199-e961-4eb6-b2e9-781eb9054d14") },
                    { new Guid("920dfba6-e527-43a4-800e-a1436add7ff1"), true, 101, new Guid("01d2950a-d07e-4342-8c05-eae2a9e802c6") }
                });

            migrationBuilder.InsertData(
                table: "MedicalTests",
                columns: new[] { "MedicalTestId", "Cost", "DepartmentId", "TestName" },
                values: new object[,]
                {
                    { new Guid("5d3c266d-1d2c-4fda-b81e-8ed37bbeeb5a"), 45f, new Guid("6f93cd11-ea0a-4233-837b-d84ed61b0b1a"), "Blood Pressure" },
                    { new Guid("e131a124-e1ed-4c3a-8439-e6424333f731"), 120.5f, new Guid("d9421643-354c-4c92-8e8a-0cceb9f58424"), "X-Ray" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "PrescriptionId", "AppointmentId", "Instructions", "Medication", "PrescriptionDate" },
                values: new object[,]
                {
                    { new Guid("25d32200-8651-4db7-b3ad-c78070829269"), new Guid("56b55b08-1d99-40c3-a6d7-30b1343a27b0"), "Take as needed for pain", "Ibuprofen", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2b017b05-3bdd-41e2-abc1-d8eaea33de7f"), new Guid("a896f84a-1ed1-44ac-8e39-cf702cb29123"), "Take one tablet daily", "Aspirin", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "TestResults",
                columns: new[] { "TestResultId", "MedicalTestId", "ResultDetails", "TestDate" },
                values: new object[] { new Guid("6331e6ce-d6c2-471b-b06d-403419f790e9"), new Guid("e131a124-e1ed-4c3a-8439-e6424333f731"), "No fractures detected", new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "TestResults",
                columns: new[] { "TestResultId", "MedicalTestId", "ResultDetails", "TestDate" },
                values: new object[] { new Guid("b227f9e6-e99f-4039-ae60-bcd41f0758a3"), new Guid("5d3c266d-1d2c-4fda-b81e-8ed37bbeeb5a"), "Normal blood pressure reading", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beds",
                keyColumn: "BedId",
                keyValue: new Guid("6ba62bd3-ab14-4bdd-94b9-6bb91b14b6c0"));

            migrationBuilder.DeleteData(
                table: "Beds",
                keyColumn: "BedId",
                keyValue: new Guid("920dfba6-e527-43a4-800e-a1436add7ff1"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("182ce1f4-0a6b-47c5-9978-039d77b27da6"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("781cd3e2-e4e9-40c3-a6ea-2f31df6996a1"));

            migrationBuilder.DeleteData(
                table: "MedicalHistories",
                keyColumn: "MedicalHistoryId",
                keyValue: new Guid("c636ff57-7816-4c8d-a56c-47a6d872487e"));

            migrationBuilder.DeleteData(
                table: "MedicalHistories",
                keyColumn: "MedicalHistoryId",
                keyValue: new Guid("e52b9e22-4e02-4a94-adf2-1f35a0c389d9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: new Guid("921441db-06e1-486f-876e-ab82cb1ca6b4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: new Guid("aec6b6f9-ab5d-44b4-9a6f-776a935b9a79"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: new Guid("08e352e2-281d-4123-8d33-1ab9db276722"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: new Guid("ad12dcef-8a24-4c6e-83ff-42f2831b8fb4"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionId",
                keyValue: new Guid("25d32200-8651-4db7-b3ad-c78070829269"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionId",
                keyValue: new Guid("2b017b05-3bdd-41e2-abc1-d8eaea33de7f"));

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumn: "TestResultId",
                keyValue: new Guid("6331e6ce-d6c2-471b-b06d-403419f790e9"));

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumn: "TestResultId",
                keyValue: new Guid("b227f9e6-e99f-4039-ae60-bcd41f0758a3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: new Guid("56b55b08-1d99-40c3-a6d7-30b1343a27b0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: new Guid("a896f84a-1ed1-44ac-8e39-cf702cb29123"));

            migrationBuilder.DeleteData(
                table: "MedicalTests",
                keyColumn: "MedicalTestId",
                keyValue: new Guid("5d3c266d-1d2c-4fda-b81e-8ed37bbeeb5a"));

            migrationBuilder.DeleteData(
                table: "MedicalTests",
                keyColumn: "MedicalTestId",
                keyValue: new Guid("e131a124-e1ed-4c3a-8439-e6424333f731"));

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "WardId",
                keyValue: new Guid("01d2950a-d07e-4342-8c05-eae2a9e802c6"));

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "WardId",
                keyValue: new Guid("25204199-e961-4eb6-b2e9-781eb9054d14"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("6f93cd11-ea0a-4233-837b-d84ed61b0b1a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("d9421643-354c-4c92-8e8a-0cceb9f58424"));
        }
    }
}
