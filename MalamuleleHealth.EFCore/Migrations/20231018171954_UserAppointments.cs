using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MalamuleleHealth.EFCore.Migrations
{
    public partial class UserAppointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Appointments",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_UserId",
                table: "Appointments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_UserId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments");

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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Appointments");

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
    }
}
