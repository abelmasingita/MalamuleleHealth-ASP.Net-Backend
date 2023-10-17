using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MalamuleleHealth.EFCore.Migrations
{
    public partial class modelOptimisation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f7b4d99-bcbb-42a6-bc76-398d7c177666");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8597bed1-c306-4f24-b5c9-2f95069c78d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "954f7592-4158-473d-8aee-f3071f8a1fd9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1604f80-1983-4ff6-8baa-bc8be508111c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd23ed6e-26c1-4c56-b770-ffb645414d7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd0100e8-fb99-476d-a19d-4d8df3ca8569");

            migrationBuilder.RenameColumn(
                name: "Speacility",
                table: "AspNetUsers",
                newName: "Specialist");

            migrationBuilder.AddColumn<string>(
                name: "PatientId",
                table: "TestResults",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorId",
                table: "Prescriptions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientId",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientId",
                table: "MedicalHistories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientId",
                table: "Invoices",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18ca512f-eccc-4690-8d7c-d3878bc8c196", "1d386ee8-f576-47cf-9d2e-bf785896fe69", "Patient", "PATIENT" },
                    { "69dd46b9-1d56-4eb9-954b-7f0d31cfbd2c", "e54e0c11-b2e7-40fe-81e7-11dcb49181c4", "Doctor", "DOCTOR" },
                    { "72b764be-8f61-4d57-99e6-dc3350059218", "9bb632b0-0080-4eff-b2ec-30c2e6747897", "LabTechnician", "LATTECHNICIAN" },
                    { "783341c6-b6d1-45f6-885d-8a04f8bbd7a4", "8a0511f6-f7fc-4c73-a64d-e1555680cf6f", "Pharmacist", "PHARMACIST" },
                    { "890c9556-b150-42dd-92eb-f0b07db6d99f", "1182eb00-0929-4a4f-b97b-29917583cb23", "Administrator", "ADMINISTRATOR" },
                    { "b053c215-4107-45fc-9481-779fcf4a2579", "5afb00e6-c8b9-4548-9297-98488562ad74", "Nurse", "NURSE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_PatientId",
                table: "TestResults",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_DoctorId",
                table: "Prescriptions",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PatientId",
                table: "Payments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHistories_PatientId",
                table: "MedicalHistories",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_PatientId",
                table: "Invoices",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_AspNetUsers_PatientId",
                table: "Invoices",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalHistories_AspNetUsers_PatientId",
                table: "MedicalHistories",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_AspNetUsers_PatientId",
                table: "Payments",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_AspNetUsers_DoctorId",
                table: "Prescriptions",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TestResults_AspNetUsers_PatientId",
                table: "TestResults",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_AspNetUsers_PatientId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalHistories_AspNetUsers_PatientId",
                table: "MedicalHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_AspNetUsers_PatientId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_AspNetUsers_DoctorId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_TestResults_AspNetUsers_PatientId",
                table: "TestResults");

            migrationBuilder.DropIndex(
                name: "IX_TestResults_PatientId",
                table: "TestResults");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_DoctorId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Payments_PatientId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_MedicalHistories_PatientId",
                table: "MedicalHistories");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_PatientId",
                table: "Invoices");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18ca512f-eccc-4690-8d7c-d3878bc8c196");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69dd46b9-1d56-4eb9-954b-7f0d31cfbd2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72b764be-8f61-4d57-99e6-dc3350059218");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "783341c6-b6d1-45f6-885d-8a04f8bbd7a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "890c9556-b150-42dd-92eb-f0b07db6d99f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b053c215-4107-45fc-9481-779fcf4a2579");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "Specialist",
                table: "AspNetUsers",
                newName: "Speacility");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5f7b4d99-bcbb-42a6-bc76-398d7c177666", "aa613f12-01b6-4e71-b3be-3af97e347a4f", "Nurse", "NURSE" },
                    { "8597bed1-c306-4f24-b5c9-2f95069c78d5", "6732e968-a81f-495a-829a-c475414e10b1", "Pharmacist", "PHARMACIST" },
                    { "954f7592-4158-473d-8aee-f3071f8a1fd9", "8781a604-3583-4008-8215-a3604d89516a", "Doctor", "DOCTOR" },
                    { "c1604f80-1983-4ff6-8baa-bc8be508111c", "f7774977-bffd-450d-a710-9149393e13de", "Patient", "PATIENT" },
                    { "dd23ed6e-26c1-4c56-b770-ffb645414d7c", "8715b9c8-8d99-4067-bcc5-f41d21d6afa6", "LabTechnician", "LATTECHNICIAN" },
                    { "fd0100e8-fb99-476d-a19d-4d8df3ca8569", "3f3f070b-8005-4307-b86f-40b50d031092", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
