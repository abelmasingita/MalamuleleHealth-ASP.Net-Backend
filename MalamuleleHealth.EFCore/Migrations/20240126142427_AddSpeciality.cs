using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MalamuleleHealth.EFCore.Migrations
{
    public partial class AddSpeciality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bb8fc01-7ed5-4339-95e7-b15b4ec7ef6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c564787-bdcc-4ead-9543-e2a7b31574e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7da7e026-d072-41f6-a0f5-767ee1693e21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d511c282-cceb-4f23-846a-f74506a80092");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f81a0f00-3ca0-4a2c-948f-e9195d91731f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8a48694-a60a-440a-94e1-0c7980cffcd4");

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "92185532-0a2d-448d-bcbb-ee809fe180ed", "1bb90c39-3858-4c3e-8110-c691f52ed9cc", "Administrator", "ADMINISTRATOR" },
                    { "acfaeb2a-69d3-4c5e-9591-af8c4ded480c", "c965fa1f-49d0-478c-870b-f31cc066dcfd", "Pharmacist", "PHARMACIST" },
                    { "b9ac56bd-4996-41eb-85c6-799f72fe4671", "17f5134e-224b-4f30-9d3c-7978b8d5212c", "Doctor", "DOCTOR" },
                    { "c5ff055d-03c6-4276-be60-07ba43e0b748", "74b876ff-04f0-4e15-8f8e-8ef57a8a3ff5", "LabTechnician", "LATTECHNICIAN" },
                    { "e166cb6c-2e32-488c-bebe-64d488786443", "ca3f7823-6b4a-4ce0-a98d-3291042853cf", "Nurse", "NURSE" },
                    { "ecb29438-7cd0-498e-81dc-5557557fd816", "b47a05de-77ad-4d08-b3f7-87143a5ca4ad", "Patient", "PATIENT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92185532-0a2d-448d-bcbb-ee809fe180ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acfaeb2a-69d3-4c5e-9591-af8c4ded480c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9ac56bd-4996-41eb-85c6-799f72fe4671");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5ff055d-03c6-4276-be60-07ba43e0b748");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e166cb6c-2e32-488c-bebe-64d488786443");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecb29438-7cd0-498e-81dc-5557557fd816");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6bb8fc01-7ed5-4339-95e7-b15b4ec7ef6d", "bea2f99c-f592-4810-924f-3b08ffa6f2c4", "LabTechnician", "LATTECHNICIAN" },
                    { "6c564787-bdcc-4ead-9543-e2a7b31574e2", "b0bbf46b-18bd-46b0-9cd2-492c68c06f7c", "Administrator", "ADMINISTRATOR" },
                    { "7da7e026-d072-41f6-a0f5-767ee1693e21", "aa6e63cf-12fe-44c9-abd7-3edc4d11aa5b", "Nurse", "NURSE" },
                    { "d511c282-cceb-4f23-846a-f74506a80092", "d5b2568e-91ad-450d-94ca-b667e8a73eb7", "Doctor", "DOCTOR" },
                    { "f81a0f00-3ca0-4a2c-948f-e9195d91731f", "942b3e74-38f5-4f60-8bc8-30e11b82c1d8", "Patient", "PATIENT" },
                    { "f8a48694-a60a-440a-94e1-0c7980cffcd4", "15e64173-3323-4226-8e4e-6403fe237634", "Pharmacist", "PHARMACIST" }
                });
        }
    }
}
