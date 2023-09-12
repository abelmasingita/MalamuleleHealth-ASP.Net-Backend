using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MalamuleleHealth.EFCore.Migrations
{
    public partial class roleSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beds",
                keyColumn: "BedId",
                keyValue: new Guid("85c88fe7-4d6a-4425-bbfb-0d23de2cb1e9"));

            migrationBuilder.DeleteData(
                table: "Beds",
                keyColumn: "BedId",
                keyValue: new Guid("eb64cfbf-8b4b-43dd-8eb5-ee019feada5c"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("1e0b9dad-4afc-4edd-a203-f03dbad262a3"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("bed6edd0-f404-46b7-abc3-aeafd1cfd4df"));

            migrationBuilder.DeleteData(
                table: "MedicalHistories",
                keyColumn: "MedicalHistoryId",
                keyValue: new Guid("109cfc6a-766f-4538-96f5-ffb67011e54e"));

            migrationBuilder.DeleteData(
                table: "MedicalHistories",
                keyColumn: "MedicalHistoryId",
                keyValue: new Guid("467f8328-7a21-4f7b-b058-cad28ae4d135"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: new Guid("0a4b4ee5-e5f4-44b8-b985-2bd25ee5f113"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: new Guid("2f465263-a5fd-41fb-8ef5-7ad4b9cd7561"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: new Guid("0bec4e95-534f-4f94-b703-c41f5b0cc55d"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: new Guid("bee3252c-4181-4c3d-9476-ef0cf2d47ecd"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionId",
                keyValue: new Guid("ce40bfb5-2087-4ad6-afe9-5f1f8d57898e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionId",
                keyValue: new Guid("ee3573bb-e323-4f77-9dae-7cb2fd9bac0f"));

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumn: "TestResultId",
                keyValue: new Guid("e10efd31-a1df-4303-b411-dd82f2843358"));

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumn: "TestResultId",
                keyValue: new Guid("fe1300d0-72b4-4fac-839c-3d0e010ac7fe"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: new Guid("f93c9c96-8b35-485a-8133-dc7ecd3706c0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: new Guid("fca8956c-51cb-4dda-8cef-8af45cfff23d"));

            migrationBuilder.DeleteData(
                table: "MedicalTests",
                keyColumn: "MedicalTestId",
                keyValue: new Guid("53a4f1f6-87c0-49e7-9f2f-430d20bf4846"));

            migrationBuilder.DeleteData(
                table: "MedicalTests",
                keyColumn: "MedicalTestId",
                keyValue: new Guid("98eb4918-e379-479f-bd00-a11647121045"));

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "WardId",
                keyValue: new Guid("127d9a5e-de40-4221-89ae-ec03d05d33f1"));

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "WardId",
                keyValue: new Guid("c36a4447-fe32-4730-9e46-8dcd62647fa0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("1a3ad739-ee7c-416c-bc17-0d1cc8061e5f"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("a7ecc9c2-3555-4495-81f4-76cc4be0fbf9"));

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentDate", "AppointmentTime", "Purpose", "Status" },
                values: new object[,]
                {
                    { new Guid("4f644f42-bfdc-410c-9b6a-52c37a4866d8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 13, 42, 15, 12, DateTimeKind.Local).AddTicks(2384), "Regular checkup", "Scheduled" },
                    { new Guid("d3d0186e-0d4d-4d88-b379-b2c2173ed217"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 13, 42, 15, 12, DateTimeKind.Local).AddTicks(2386), "Follow-up", "Scheduled" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e36a6c4-9d4d-4b62-b60c-67b66f95c149", "3e6ecfc8-a556-4245-87bf-f0a74818d7fb", "Administrator", "ADMINISTRATOR" },
                    { "fe6a2b11-c7d0-4587-b9ab-ca05dc2f460b", "fa1af129-6b03-4fe7-a6b3-66b97473ff5a", "Patient", "PATIENT" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("3ed8177e-a277-434f-9fe3-dc831ee38840"), "Heart-related issues", "Cardiology" },
                    { new Guid("bbe82890-ed9d-4472-a1c7-00bbf3290f54"), "Musculoskeletal disorders", "Orthopedics" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "DueDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("15c49e84-194f-423d-b49b-258d340cfbb2"), new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Paid", 150.25f },
                    { new Guid("3acf8ea9-e299-4c20-adf9-c60512b627f1"), new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Pending", 250.5f }
                });

            migrationBuilder.InsertData(
                table: "MedicalHistories",
                columns: new[] { "MedicalHistoryId", "DiagnosisDate", "MedicalCondition", "Treatment" },
                values: new object[,]
                {
                    { new Guid("74b65123-534f-4ef8-92e5-2b3707169b10"), new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "Diabetes", "Insulin therapy" },
                    { new Guid("8ccef679-2b4a-4f4f-a56b-bfbbaf6561e4"), new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Hypertension", "Medication and lifestyle changes" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "AppointmentDate", "AppointmentTime", "Purpose", "Status" },
                values: new object[,]
                {
                    { new Guid("52fd11c3-d83d-46b7-a135-3f8df4ef0973"), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 13, 42, 15, 12, DateTimeKind.Local).AddTicks(2558), "Appointment Reminder", "Sent" },
                    { new Guid("a1d78578-f173-4325-8a00-2da289a01691"), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 13, 42, 15, 12, DateTimeKind.Local).AddTicks(2561), "Appointment Confirmation", "Sent" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "PaymentDate" },
                values: new object[,]
                {
                    { new Guid("1f849fef-5dea-441c-89dd-0776b0a9820e"), 75f, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f4c2d548-043c-4edd-87e7-4cce14959c87"), 100.25f, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Wards",
                columns: new[] { "WardId", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { new Guid("29bcf8e5-e9d3-4449-9d93-cd37d9b653e4"), null, "General Ward" },
                    { new Guid("8a254245-38e9-43c8-ab3b-2124d6e2d8ad"), null, "Pediatrics Ward" }
                });

            migrationBuilder.InsertData(
                table: "Beds",
                columns: new[] { "BedId", "Availability", "Number", "WardId" },
                values: new object[,]
                {
                    { new Guid("4fc8947a-09f4-441a-91f0-f6a42cb079b4"), false, 102, new Guid("8a254245-38e9-43c8-ab3b-2124d6e2d8ad") },
                    { new Guid("ba2922a3-31ed-4516-ab13-6bf2527ae342"), true, 101, new Guid("29bcf8e5-e9d3-4449-9d93-cd37d9b653e4") }
                });

            migrationBuilder.InsertData(
                table: "MedicalTests",
                columns: new[] { "MedicalTestId", "Cost", "DepartmentId", "TestName" },
                values: new object[,]
                {
                    { new Guid("31f37125-2889-4834-bbb3-ce99c45b20a4"), 45f, new Guid("3ed8177e-a277-434f-9fe3-dc831ee38840"), "Blood Pressure" },
                    { new Guid("67ef5efa-2e83-47ae-96d1-0d05b1250b6c"), 120.5f, new Guid("bbe82890-ed9d-4472-a1c7-00bbf3290f54"), "X-Ray" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "PrescriptionId", "AppointmentId", "Instructions", "Medication", "PrescriptionDate" },
                values: new object[,]
                {
                    { new Guid("a8b8af17-2338-4bea-9815-2861d02858f7"), new Guid("d3d0186e-0d4d-4d88-b379-b2c2173ed217"), "Take as needed for pain", "Ibuprofen", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ef48bb34-ed89-410f-820d-f771f63acfa8"), new Guid("4f644f42-bfdc-410c-9b6a-52c37a4866d8"), "Take one tablet daily", "Aspirin", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "TestResults",
                columns: new[] { "TestResultId", "MedicalTestId", "ResultDetails", "TestDate" },
                values: new object[] { new Guid("b6aaf5c0-83d8-4dbd-853e-9d704bd6d12e"), new Guid("31f37125-2889-4834-bbb3-ce99c45b20a4"), "Normal blood pressure reading", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "TestResults",
                columns: new[] { "TestResultId", "MedicalTestId", "ResultDetails", "TestDate" },
                values: new object[] { new Guid("b7d57c20-3d49-4d0a-b7cd-6b5dd234b53c"), new Guid("67ef5efa-2e83-47ae-96d1-0d05b1250b6c"), "No fractures detected", new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e36a6c4-9d4d-4b62-b60c-67b66f95c149");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe6a2b11-c7d0-4587-b9ab-ca05dc2f460b");

            migrationBuilder.DeleteData(
                table: "Beds",
                keyColumn: "BedId",
                keyValue: new Guid("4fc8947a-09f4-441a-91f0-f6a42cb079b4"));

            migrationBuilder.DeleteData(
                table: "Beds",
                keyColumn: "BedId",
                keyValue: new Guid("ba2922a3-31ed-4516-ab13-6bf2527ae342"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("15c49e84-194f-423d-b49b-258d340cfbb2"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("3acf8ea9-e299-4c20-adf9-c60512b627f1"));

            migrationBuilder.DeleteData(
                table: "MedicalHistories",
                keyColumn: "MedicalHistoryId",
                keyValue: new Guid("74b65123-534f-4ef8-92e5-2b3707169b10"));

            migrationBuilder.DeleteData(
                table: "MedicalHistories",
                keyColumn: "MedicalHistoryId",
                keyValue: new Guid("8ccef679-2b4a-4f4f-a56b-bfbbaf6561e4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: new Guid("52fd11c3-d83d-46b7-a135-3f8df4ef0973"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: new Guid("a1d78578-f173-4325-8a00-2da289a01691"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: new Guid("1f849fef-5dea-441c-89dd-0776b0a9820e"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: new Guid("f4c2d548-043c-4edd-87e7-4cce14959c87"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionId",
                keyValue: new Guid("a8b8af17-2338-4bea-9815-2861d02858f7"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionId",
                keyValue: new Guid("ef48bb34-ed89-410f-820d-f771f63acfa8"));

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumn: "TestResultId",
                keyValue: new Guid("b6aaf5c0-83d8-4dbd-853e-9d704bd6d12e"));

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumn: "TestResultId",
                keyValue: new Guid("b7d57c20-3d49-4d0a-b7cd-6b5dd234b53c"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: new Guid("4f644f42-bfdc-410c-9b6a-52c37a4866d8"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: new Guid("d3d0186e-0d4d-4d88-b379-b2c2173ed217"));

            migrationBuilder.DeleteData(
                table: "MedicalTests",
                keyColumn: "MedicalTestId",
                keyValue: new Guid("31f37125-2889-4834-bbb3-ce99c45b20a4"));

            migrationBuilder.DeleteData(
                table: "MedicalTests",
                keyColumn: "MedicalTestId",
                keyValue: new Guid("67ef5efa-2e83-47ae-96d1-0d05b1250b6c"));

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "WardId",
                keyValue: new Guid("29bcf8e5-e9d3-4449-9d93-cd37d9b653e4"));

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "WardId",
                keyValue: new Guid("8a254245-38e9-43c8-ab3b-2124d6e2d8ad"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("3ed8177e-a277-434f-9fe3-dc831ee38840"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("bbe82890-ed9d-4472-a1c7-00bbf3290f54"));

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentDate", "AppointmentTime", "Purpose", "Status" },
                values: new object[,]
                {
                    { new Guid("f93c9c96-8b35-485a-8133-dc7ecd3706c0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 13, 35, 56, 978, DateTimeKind.Local).AddTicks(1122), "Regular checkup", "Scheduled" },
                    { new Guid("fca8956c-51cb-4dda-8cef-8af45cfff23d"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 13, 35, 56, 978, DateTimeKind.Local).AddTicks(1125), "Follow-up", "Scheduled" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1a3ad739-ee7c-416c-bc17-0d1cc8061e5f"), "Musculoskeletal disorders", "Orthopedics" },
                    { new Guid("a7ecc9c2-3555-4495-81f4-76cc4be0fbf9"), "Heart-related issues", "Cardiology" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "DueDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("1e0b9dad-4afc-4edd-a203-f03dbad262a3"), new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Paid", 150.25f },
                    { new Guid("bed6edd0-f404-46b7-abc3-aeafd1cfd4df"), new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Pending", 250.5f }
                });

            migrationBuilder.InsertData(
                table: "MedicalHistories",
                columns: new[] { "MedicalHistoryId", "DiagnosisDate", "MedicalCondition", "Treatment" },
                values: new object[,]
                {
                    { new Guid("109cfc6a-766f-4538-96f5-ffb67011e54e"), new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Hypertension", "Medication and lifestyle changes" },
                    { new Guid("467f8328-7a21-4f7b-b058-cad28ae4d135"), new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "Diabetes", "Insulin therapy" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "AppointmentDate", "AppointmentTime", "Purpose", "Status" },
                values: new object[,]
                {
                    { new Guid("0a4b4ee5-e5f4-44b8-b985-2bd25ee5f113"), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 13, 35, 56, 978, DateTimeKind.Local).AddTicks(1532), "Appointment Confirmation", "Sent" },
                    { new Guid("2f465263-a5fd-41fb-8ef5-7ad4b9cd7561"), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 13, 35, 56, 978, DateTimeKind.Local).AddTicks(1528), "Appointment Reminder", "Sent" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "PaymentDate" },
                values: new object[,]
                {
                    { new Guid("0bec4e95-534f-4f94-b703-c41f5b0cc55d"), 100.25f, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("bee3252c-4181-4c3d-9476-ef0cf2d47ecd"), 75f, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Wards",
                columns: new[] { "WardId", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { new Guid("127d9a5e-de40-4221-89ae-ec03d05d33f1"), null, "General Ward" },
                    { new Guid("c36a4447-fe32-4730-9e46-8dcd62647fa0"), null, "Pediatrics Ward" }
                });

            migrationBuilder.InsertData(
                table: "Beds",
                columns: new[] { "BedId", "Availability", "Number", "WardId" },
                values: new object[,]
                {
                    { new Guid("85c88fe7-4d6a-4425-bbfb-0d23de2cb1e9"), true, 101, new Guid("127d9a5e-de40-4221-89ae-ec03d05d33f1") },
                    { new Guid("eb64cfbf-8b4b-43dd-8eb5-ee019feada5c"), false, 102, new Guid("c36a4447-fe32-4730-9e46-8dcd62647fa0") }
                });

            migrationBuilder.InsertData(
                table: "MedicalTests",
                columns: new[] { "MedicalTestId", "Cost", "DepartmentId", "TestName" },
                values: new object[,]
                {
                    { new Guid("53a4f1f6-87c0-49e7-9f2f-430d20bf4846"), 120.5f, new Guid("1a3ad739-ee7c-416c-bc17-0d1cc8061e5f"), "X-Ray" },
                    { new Guid("98eb4918-e379-479f-bd00-a11647121045"), 45f, new Guid("a7ecc9c2-3555-4495-81f4-76cc4be0fbf9"), "Blood Pressure" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "PrescriptionId", "AppointmentId", "Instructions", "Medication", "PrescriptionDate" },
                values: new object[,]
                {
                    { new Guid("ce40bfb5-2087-4ad6-afe9-5f1f8d57898e"), new Guid("f93c9c96-8b35-485a-8133-dc7ecd3706c0"), "Take one tablet daily", "Aspirin", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ee3573bb-e323-4f77-9dae-7cb2fd9bac0f"), new Guid("fca8956c-51cb-4dda-8cef-8af45cfff23d"), "Take as needed for pain", "Ibuprofen", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "TestResults",
                columns: new[] { "TestResultId", "MedicalTestId", "ResultDetails", "TestDate" },
                values: new object[] { new Guid("e10efd31-a1df-4303-b411-dd82f2843358"), new Guid("98eb4918-e379-479f-bd00-a11647121045"), "Normal blood pressure reading", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "TestResults",
                columns: new[] { "TestResultId", "MedicalTestId", "ResultDetails", "TestDate" },
                values: new object[] { new Guid("fe1300d0-72b4-4fac-839c-3d0e010ac7fe"), new Guid("53a4f1f6-87c0-49e7-9f2f-430d20bf4846"), "No fractures detected", new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
