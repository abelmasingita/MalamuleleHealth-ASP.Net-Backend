using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MalamuleleHealth.EFCore.Migrations
{
    public partial class UserAppointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "329e7adf-0587-4bf1-9fb7-f753d634ba88", "6a165408-2d3e-4156-87ee-d7bd480ad385", "Doctor", "DOCTOR" },
                    { "a0fda065-8200-44da-a690-fc8d9c00ad6e", "08b2fb36-fae1-4d5a-a624-afbd3a3946d4", "LabTechnician", "LATTECHNICIAN" },
                    { "afc69361-6764-4f4c-bb3a-1aa4773486a1", "4ac63e98-920d-47e9-90a8-c4c7d906f1e5", "Administrator", "ADMINISTRATOR" },
                    { "b4d0facf-26eb-4766-9ae0-73e7683f78ca", "71f2319d-232c-4358-ab86-a4947ba1ff7c", "Pharmacist", "PHARMACIST" },
                    { "c629aac2-2d55-4bb7-bda1-152328b7c136", "dacdae0a-63f2-4cfb-8d96-01c5f2aa8561", "Patient", "PATIENT" },
                    { "e241ccca-d662-4d11-8208-1630bde6797a", "8b558fed-6b7b-4e3b-9238-02584e26af81", "Nurse", "NURSE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "329e7adf-0587-4bf1-9fb7-f753d634ba88");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0fda065-8200-44da-a690-fc8d9c00ad6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afc69361-6764-4f4c-bb3a-1aa4773486a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4d0facf-26eb-4766-9ae0-73e7683f78ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c629aac2-2d55-4bb7-bda1-152328b7c136");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e241ccca-d662-4d11-8208-1630bde6797a");
        }
    }
}
